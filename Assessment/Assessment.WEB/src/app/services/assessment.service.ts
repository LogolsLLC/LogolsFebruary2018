import { Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Assessment } from '../entities/assessment';

export class AssessmentService {
    http: Http;
    baseUrl: string;
    controller: string = "api/Assessment/";

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

    public getQuestions(id: number) {
        return this.http.get(this.baseUrl + this.controller + "Questions/" + id);
    }

    public update(assessment: Assessment) {
        return this.http.put(this.baseUrl + this.controller, assessment);
    }

    public insert(assessment: Assessment) {
        return this.http.post(this.baseUrl + this.controller, assessment);
    }

    public delete(id: number) {
        return this.http.delete(this.baseUrl + this.controller + id);
    }
}