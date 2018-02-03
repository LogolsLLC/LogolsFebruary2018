import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { AdminComponent } from './components/admin/admin.component';
import { AssessmentComponent } from './components/assessment/assessment.component';
import { QuestionComponent } from './components/question/question.component';
import { AssessmentAdminComponent } from './components/assessmentAdmin/assessmentAdmin.component';
import { QuestionAdminComponent } from './components/questionAdmin/questionAdmin.component';
import { LevelAdminComponent } from './components/levelAdmin/levelAdmin.component';
import { SubjectAdminComponent } from './components/subjectAdmin/subjectAdmin.component';
import { AnswerAdminComponent } from './components/answerAdmin/answerAdmin.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    NavMenuComponent,
    AdminComponent,
    AssessmentComponent,
    QuestionComponent,
    AssessmentAdminComponent,
    QuestionAdminComponent,
    LevelAdminComponent,
    SubjectAdminComponent,
    AnswerAdminComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    FormsModule,
    RouterModule.forRoot([
        { path: '', redirectTo: 'home', pathMatch: 'full' },
        { path: 'home', component: HomeComponent },
        { path: 'admin', component: AdminComponent },
        { path: 'assessment/:id', component: AssessmentComponent },
        { path: 'assessmentAdmin', component: AssessmentAdminComponent },
        { path: 'questionAdmin/:assessmentID', component: QuestionAdminComponent },
        { path: 'answerAdmin/:questionID', component: AnswerAdminComponent },
        { path: 'levelAdmin', component: LevelAdminComponent },
        { path: 'subjectAdmin', component: SubjectAdminComponent },
        { path: '**', redirectTo: 'home' }
    ])
  ],
  providers: [
    { provide: 'BASE_URL', useFactory: getBaseUrl }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

export function getBaseUrl() {
  return "http://localhost:5000/"; //document.getElementsByTagName('base')[0].href;
}
