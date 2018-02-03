import { Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Question } from '../entities/question';

export class QuestionService {
    http: Http;
    baseUrl: string;
    controller: string = "api/Question/";

    constructor(http: Http, baseUrl: string) {
        this.http = http;
        this.baseUrl = baseUrl;
    }

    public getAll() {
        return this.http.get(this.baseUrl + this.controller);
    }

    public getAnswers(id: number) {
        return this.http.get(this.baseUrl + this.controller + 'Answers/' + id);
    }

    public get(id: number) {
        return this.http.get(this.baseUrl + this.controller + id);
    }

    public update(question: Question) {
        return this.http.put(this.baseUrl + this.controller, question);
    }

    public insert(question: Question) {
        return this.http.post(this.baseUrl + this.controller, question);
    }

    public delete(id: number) {
        return this.http.delete(this.baseUrl + this.controller + id);
    }
}