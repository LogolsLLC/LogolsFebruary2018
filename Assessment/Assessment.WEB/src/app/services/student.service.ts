import { Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Student } from '../entities/student';

export class StudentService {
    http: Http;
    baseUrl: string;
    controller: string = "api/Student/";

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

    public update(student: Student) {
        return this.http.put(this.baseUrl + this.controller, student);
    }

    public insert(student: Student) {
        return this.http.post(this.baseUrl + this.controller, student);
    }

    public delete(student: Student) {
        return this.http.delete(this.baseUrl + this.controller);
    }
}