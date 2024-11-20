import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LandingPageComponent } from './landing-page/landing-page.component';

// TODO: Change Names to actual Module Names
const routes: Routes = [
  { path: '', pathMatch: "full", component: LandingPageComponent },
  { path: 'LandingPage', redirectTo: '' },
  // { path: 'Projects', component: ProjectListPageComponent },
  // { path: 'Projects/:id', component: ProjectPageComponent },
  // { path: 'Help', component: HelpPageComponent },
  // { path: 'User', component: UserPageComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
