import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LandingPageComponent } from './landing-page/landing-page.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { provideHttpClient } from '@angular/common/http';
import { ProjectListPageComponent } from './projects/project-list-page/project-list-page.component';
import { ProjectDetailComponent } from './projects/project-detail/project-detail.component';
import { ProjectPageComponent } from './projects/project-page/project-page.component';

@NgModule({
  declarations: [
    AppComponent,
    LandingPageComponent,
    ProjectPageComponent,
    ProjectListPageComponent,
    ProjectDetailComponent,
    NavBarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [provideHttpClient()], // Using this method rather than the module as the module is labeled as depricated
  bootstrap: [AppComponent]
})
export class AppModule { }
