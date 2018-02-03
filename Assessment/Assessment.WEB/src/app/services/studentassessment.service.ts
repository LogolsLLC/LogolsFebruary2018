import { Inject } from '@angular/core';
import { Http } from '@angular/http';
import { StudentAssessment } from '../entities/studentassessment';

export class StudentAssessmentService {
    http: Http;
    baseUrl: string;
    controller: string = "api/StudentAssessment/";

    constructor(http: Http, baseUrl: string) {
        this.http = http;
        this.baseUrl = baseUrl;
    }

    public getAll() {
        return this.http.get(this.baseUrl + this.controller);
    }

    public get(id: number) {
        return this.http.get(this.baseUrl + this.controller + id);
    }

    public update(studentassessment: StudentAssessment) {
        return this.http.put(this.baseUrl + this.controller, studentassessment);
    }

    public insert(studentassessment: StudentAssessment) {
        return this.http.post(this.baseUrl + this.controller, studentassessment);
    }

    public delete(studentassessment: StudentAssessment) {
        return this.http.delete(this.baseUrl + this.controller);
    }
}