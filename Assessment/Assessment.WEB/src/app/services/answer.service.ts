import { Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Answer } from '../entities/answer';

export class AnswerService {
    http: Http;
    baseUrl: string;
    controller: string = "api/Answer/";

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

    public update(answer: Answer) {
        return this.http.put(this.baseUrl + this.controller, answer);
    }

    public insert(answer: Answer) {
        return this.http.post(this.baseUrl + this.controller, answer);
    }

    public delete(id: number) {
        return this.http.delete(this.baseUrl + this.controller + id);
    }
}