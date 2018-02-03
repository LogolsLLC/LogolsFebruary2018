import { Component, Inject, EventEmitter, Input, Output } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Http } from '@angular/http';
import { QuestionService } from './../../services/question.service';
import { Question } from './../../entities/question';
import { Answer } from './../../entities/answer';

@Component({
    selector: 'question',
    templateUrl: './question.component.html',
    styleUrls: ['./question.component.css']
})
export class QuestionComponent {
    @Input() question: Question;
    @Output() onSelectionChanged = new EventEmitter<boolean>();
    public answers: Answer[];
    public result: string;

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) {}

    ngOnInit() {
        this.result = "";
        let questionService = new QuestionService(this.http, this.baseUrl);
        questionService.getAnswers(this.question.questionID).subscribe(result => {
            this.answers = result.json() as Answer[];
        }, error => console.error(error));
    }

    ngOnDestroy() {

    }

    onSelectionChange(answer: Answer) {
        if (answer.isCorrect) {
            this.result = "Correct!";
        }
        else {
            this.result = "Sorry";
        }
        this.question.isCorrect = answer.isCorrect;
        this.onSelectionChanged.emit(this.question.isCorrect);
    }
}