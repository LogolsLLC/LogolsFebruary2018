import { Component, Inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Http } from '@angular/http';
import { Answer } from './../../entities/answer';
import { Assessment } from './../../entities/assessment';
import { Question } from './../../entities/question';
import { AssessmentService } from './../../services/assessment.service';
import { QuestionService } from './../../services/question.service';

@Component({
    selector: 'assessment',
    templateUrl: './assessment.component.html'
})
export class AssessmentComponent {
    public assessment: Assessment;
    public questions: Question[];
    public score: number;
    private id: number;
    private sub: any;

    constructor(private route: ActivatedRoute, private http: Http, @Inject('BASE_URL') private baseUrl: string) {}

    ngOnInit() {
        this.score = 0;
        this.sub = this.route.params.subscribe(params => {
            this.id = +params['id']; // (+) converts string 'id' to a number
            let assessmentService = new AssessmentService(this.http, this.baseUrl);
            assessmentService.get(this.id).subscribe(result => {
                this.assessment = result.json() as Assessment;
            }, error => console.error(error));

            assessmentService.getQuestions(this.id).subscribe(result => {
                this.questions = result.json() as Question[];
            }, error => console.error(error));
        });
    }

    ngOnDestroy() {
        this.sub.unsubscribe();
    }

    onSelectionChange(isCorrect: boolean) {
        let totalNumber = 0;
        let correctQuestions = 0;

        for (totalNumber; totalNumber < this.questions.length; totalNumber++) {
            if (this.questions[totalNumber].isCorrect) {
                correctQuestions++;
            }
        }

        this.score = correctQuestions / totalNumber * 100;
    }
}