import { Component, Inject } from '@angular/core';
import { Router } from '@angular/router';
import { Http } from '@angular/http';
import { Assessment } from './../../entities/assessment';
import { Level } from './../../entities/level';
import { LevelService } from './../../services/level.service';

@Component({
    selector: 'levelAdmin',
    templateUrl: './levelAdmin.component.html'
})
export class LevelAdminComponent {
    public updateLevel: Level;
    public levels: Level[];
    private operation: string;

    constructor(private router: Router, private http: Http, @Inject('BASE_URL') private baseUrl: string) {}

    ngOnInit() {
        this.reload();
    }

    reload() {
        this.updateLevel = { levelNumber: 0, name: "" };
        let levelService = new LevelService(this.http, this.baseUrl);
        levelService.getAll().subscribe(result => {
            this.levels = result.json() as Level[];
        }, error => console.error(error));
    }

    onAddClicked(event: any) {
        this.updateLevel = { levelNumber: 0, name: "" };
        this.operation = "Add";
    }

    onEditClicked(level: Level) {
        this.updateLevel = level;
        this.operation = "Update";
    }

    onDeleteClicked(level: Level) {
        let levelService = new LevelService(this.http, this.baseUrl);
        levelService.delete(level.levelNumber).subscribe(result => { this.reload(); }, error => console.error(error));
    }

    onUpdateClicked(level: Level) {
        let levelService = new LevelService(this.http, this.baseUrl);

        if (this.operation == "Add") {
            levelService.insert(level).subscribe(result => { this.reload(); }, error => console.error(error));
        }
        else {
            levelService.update(level).subscribe(result => { this.reload(); }, error => console.error(error));
        }
    }
}