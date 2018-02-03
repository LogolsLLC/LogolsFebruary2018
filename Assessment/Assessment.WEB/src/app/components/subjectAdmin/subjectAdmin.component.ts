import { Component, Inject } from '@angular/core';
import { Router } from '@angular/router';
import { Http } from '@angular/http';
import { Subject } from './../../entities/subject';
import { SubjectService } from './../../services/subject.service';

@Component({
    selector: 'subjectAdmin',
    templateUrl: './subjectAdmin.component.html'
})
export class SubjectAdminComponent {
    public updateSubject: Subject;
    public subjects: Subject[];

    constructor(private router: Router, private http: Http, @Inject('BASE_URL') private baseUrl: string) {}

    ngOnInit() {
        this.reload();
    }

    reload() {
        this.updateSubject = { description: "", name: "", subjectID: 0 };

        let subjectService = new SubjectService(this.http, this.baseUrl);
        subjectService.getAll().subscribe(result => {
            this.subjects = result.json() as Subject[];
        }, error => console.error(error));
    }

    onAddClicked(event: any) {
        this.updateSubject = { description: "", name: "", subjectID: 0 };
    }

    onEditClicked(subject: Subject) {
        this.updateSubject = subject;
    }

    onDeleteClicked(subject: Subject) {
        let subjectService = new SubjectService(this.http, this.baseUrl);
        subjectService.delete(subject.subjectID).subscribe(result => { this.reload(); }, error => console.error(error));
    }

    onUpdateClicked(subject: Subject) {
        let assessmentService = new SubjectService(this.http, this.baseUrl);

        if (subject.subjectID < 1) {
            assessmentService.insert(subject).subscribe(result => { this.reload(); }, error => console.error(error));
        }
        else {
            assessmentService.update(subject).subscribe(result => { this.reload(); }, error => console.error(error));
        }
    }
}