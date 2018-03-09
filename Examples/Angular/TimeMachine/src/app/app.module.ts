import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { LogComponent } from './log.component';
import { TimeMachineComponent } from './timeMachine.component';
import { LogService } from './services/logService';

const appRoutes: Routes = [
  { path: 'log', component: LogComponent },
  { path: 'timemachine', component: TimeMachineComponent },
  { path: '', redirectTo: '/timemachine', pathMatch: 'full' }
];

@NgModule({
  declarations: [
    AppComponent,
    LogComponent,
    TimeMachineComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot(
      appRoutes,
      { enableTracing: true } // <-- debugging purposes only
    )
  ],
  providers: [
    LogService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
