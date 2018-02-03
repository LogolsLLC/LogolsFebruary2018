import { Component, Inject, EventEmitter, Input, Output } from '@angular/core';
import { Router } from '@angular/router';
import { ActivatedRoute } from '@angular/router';
import { Http } from '@angular/http';
import { Assessment } from './../../entities/assessment';
import { Level } from './../../entities/level';
import { Question } from './../../entities/question';
import { AssessmentService } from './../../services/assessment.service';
import { QuestionService } from './../../services/question.service';

@Component({
    selector: 'questionAdmin',
    templateUrl: './questionAdmin.component.html'
})
export class QuestionAdminComponent {
    @Input() assessmentID: number;
    public updateQuestion: Question;
    public questions: Question[];
    public assessments: Assessment[] = [];
    private sub: any;

    constructor(private router: Router, private route: ActivatedRoute, private http: Http, @Inject('BASE_URL') private baseUrl: string) {}

    ngOnInit() {
        this.sub = this.route.params.subscribe(params => {
            this.assessmentID = +params['assessmentID']; // (+) converts string 'id' to a number
            this.reload();
        });
    }

    ngOnDestroy() {
        this.sub.unsubscribe();
    }

    reload() {
        this.updateQuestion = { questionID: 0, assessmentID: this.assessmentID, text: "", isCorrect: false };

        let assessmentService = new AssessmentService(this.http, this.baseUrl);
        assessmentService.getQuestions(this.assessmentID).subscribe(result => {
            this.questions = result.json() as Question[];
        }, error => console.error(error));

        assessmentService.get(this.assessmentID).subscribe(result => {
            this.assessments.push(result.json());
        }, error => console.error(error));
    }

    onAddClicked(event: any) {
        let assessmentService = new AssessmentService(this.http, this.baseUrl);
        this.updateQuestion = { questionID: 0, assessmentID: this.assessmentID, text: "", isCorrect: false };
    }

    onEditClicked(question: Question) {
        this.updateQuestion = question;
    }

    onDeleteClicked(question: Question) {
        let questionService = new QuestionService(this.http, this.baseUrl);
        questionService.delete(question.questionID).subscribe(result => { this.reload(); }, error => console.error(error));
    }

    onAnswerClicked(question: Question) {
        this.router.navigate(['/answerAdmin', question.questionID]);
    }

    onUpdateClicked(question: Question) {
        let questionService = new QuestionService(this.http, this.baseUrl);

        if (question.questionID < 1) {
            questionService.insert(question).subscribe(result => { this.reload(); }, error => console.error(error));
        }
        else {
            questionService.update(question).subscribe(result => { this.reload(); }, error => console.error(error));
        }
    }
}