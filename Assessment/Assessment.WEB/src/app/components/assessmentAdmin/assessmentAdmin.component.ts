import { Component, Inject } from '@angular/core';
import { Router } from '@angular/router';
import { Http } from '@angular/http';
import { Assessment } from './../../entities/assessment';
import { Level } from './../../entities/level';
import { Subject } from './../../entities/subject';
import { AssessmentService } from './../../services/assessment.service';
import { LevelService } from './../../services/level.service';
import { SubjectService } from './../../services/subject.service';

@Component({
    selector: 'assessmentAdmin',
    templateUrl: './assessmentAdmin.component.html'
})
export class AssessmentAdminComponent {
    public updateAssessment: Assessment;
    public levels: Level[];
    public subjects: Subject[];
    public assessments: Assessment[];

    constructor(private router: Router, private http: Http, @Inject('BASE_URL') private baseUrl: string) {}

    ngOnInit() {
        this.reload();
    }

    reload() {
        this.updateAssessment = { assessmentID: 0, levelNumber: 2, subjectID: 1, name: "test" };

        let levelService = new LevelService(this.http, this.baseUrl);
        levelService.getAll().subscribe(result => {
            this.levels = result.json() as Level[];
        }, error => console.error(error));

        let subjectService = new SubjectService(this.http, this.baseUrl);
        subjectService.getAll().subscribe(result => {
            this.subjects = result.json() as Subject[];
        }, error => console.error(error));

        let assessmentService = new AssessmentService(this.http, this.baseUrl);
        assessmentService.getAll().subscribe(result => {
            this.assessments = result.json() as Assessment[];
        }, error => console.error(error));
    }

    onAddClicked(event: any) {
        this.updateAssessment = { assessmentID: 0, levelNumber: 2, subjectID: 1, name: "" };
    }

    onEditClicked(assessment: Assessment) {
        this.updateAssessment = assessment;
    }

    onDeleteClicked(assessment: Assessment) {
        let assessmentService = new AssessmentService(this.http, this.baseUrl);
        assessmentService.delete(assessment.assessmentID).subscribe(result => { this.reload(); }, error => console.error(error));
    }

    onUpdateClicked(assessment: Assessment) {
        let assessmentService = new AssessmentService(this.http, this.baseUrl);

        if (assessment.assessmentID < 1) {
            assessmentService.insert(assessment).subscribe(result => { this.reload(); }, error => console.error(error));
        }
        else {
            assessmentService.update(assessment).subscribe(result => { this.reload(); }, error => console.error(error));
        }
    }

    onQuestionClicked(assessment: Assessment) {
        this.router.navigate(['/questionAdmin', assessment.assessmentID]);
    }
}