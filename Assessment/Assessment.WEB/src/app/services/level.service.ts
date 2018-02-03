import { Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Level } from '../entities/level';

export class LevelService {
    http: Http;
    baseUrl: string;
    controller: string = "api/Level/";

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

    public update(level: Level) {
        return this.http.put(this.baseUrl + this.controller, level);
    }

    public insert(level: Level) {
        return this.http.post(this.baseUrl + this.controller, level);
    }

    public delete(id: number) {
        return this.http.delete(this.baseUrl + this.controller + id);
    }
}