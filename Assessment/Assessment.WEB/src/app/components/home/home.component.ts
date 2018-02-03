import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Assessment } from './../../entities/assessment';
import { AssessmentService } from './../../services/assessment.service';

@Component({
    selector: 'home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css']
})
export class HomeComponent {
    public assessments: Assessment[];

    constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) {}

    ngOnInit() {
        let assessmentService = new AssessmentService(this.http, this.baseUrl);
        assessmentService.getAll().subscribe(result => {
            this.assessments = result.json() as Assessment[];
        }, error => console.error(error));
    }
}