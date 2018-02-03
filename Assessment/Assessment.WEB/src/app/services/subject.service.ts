import { Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Subject } from '../entities/subject';

export class SubjectService {
    http: Http;
    baseUrl: string;
    controller: string = "api/Subject/";

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

    public update(subject: Subject) {
        return this.http.put(this.baseUrl + this.controller, subject);
    }

    public insert(subject: Subject) {
        return this.http.post(this.baseUrl + this.controller, subject);
    }

    public delete(id: number) {
        return this.http.delete(this.baseUrl + this.controller + id);
    }
}