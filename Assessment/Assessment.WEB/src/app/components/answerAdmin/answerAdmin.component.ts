import { Component, Inject, EventEmitter, Input, Output } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Http } from '@angular/http';
import { Question } from './../../entities/question';
import { Answer } from './../../entities/answer';
import { AnswerService } from './../../services/answer.service';
import { QuestionService } from './../../services/question.service';

@Component({
    selector: 'answerAdmin',
    templateUrl: './answerAdmin.component.html'
})
export class AnswerAdminComponent {
    @Input() questionID: number;
    public updateAnswer: Answer;
    public answers: Answer[];
    public questions: Question[] = [];
    private sub: any;

    constructor(private route: ActivatedRoute, private http: Http, @Inject('BASE_URL') private baseUrl: string) {}

    ngOnInit() {
        this.sub = this.route.params.subscribe(params => {
            this.questionID = +params['questionID']; // (+) converts string 'id' to a number
            let questionService = new QuestionService(this.http, this.baseUrl);
            questionService.get(this.questionID).subscribe(result => {
                this.questions.push(result.json());
            }, error => console.error(error));

            this.reload();
        });
    }

    ngOnDestroy() {
        this.sub.unsubscribe();
    }

    reload() {
        this.updateAnswer = { answerID: 0, questionID: this.questionID, text: "", isCorrect: false };

        let questionService = new QuestionService(this.http, this.baseUrl);
        questionService.getAnswers(this.questionID).subscribe(result => {
            this.answers = result.json() as Answer[];
        }, error => console.error(error));
    }

    onAddClicked(event: any) {
        let questionService = new QuestionService(this.http, this.baseUrl);
        this.updateAnswer = { answerID: 0, questionID: this.questionID, text: "", isCorrect: false };
    }

    onEditClicked(answer: Answer) {
        this.updateAnswer = answer;
    }

    onDeleteClicked(answer: Answer) {
        let answerService = new AnswerService(this.http, this.baseUrl);
        answerService.delete(answer.answerID).subscribe(result => { this.reload(); }, error => console.error(error));
    }

    onUpdateClicked(answer: Answer) {
        let answerService = new AnswerService(this.http, this.baseUrl);

        if (answer.answerID < 1) {
            answerService.insert(answer).subscribe(result => { this.reload(); }, error => console.error(error));
        }
        else {
            answerService.update(answer).subscribe(result => { this.reload(); }, error => console.error(error));
        }
    }
}