import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LandingPageComponent } from './landing-page/landing-page.component';
import { ProjectListPageComponent } from './projects/project-list-page/project-list-page.component';
import { ProjectPageComponent } from './projects/project-page/project-page.component';
import { ChangelogComponent } from './changelog/changelog.component'
import { HelpProjectComponent } from './Help-Page/Help-Page.component';
import { AssetListComponent } from './asset/asset-list/asset-list.component';
import { AssetDetailComponent } from './asset/asset-detail/asset-detail.component';
import { ProfilePageComponent } from './profile-page/profile-page.component';
import { ComingSoonComponent } from './coming-soon/coming-soon.component';
import { AboutModelCabinetComponent } from './About-ModelCabinet/About-ModelCabinet.component';
import { TagEditComponent } from './tags/tag-edit/tag-edit.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { authGuard } from './guards/auth.guard';
import { nonAuthGuard } from './guards/non-auth.guard';

// TODO: Change Names to actual Module Names
const routes: Routes = [
  { path: '', pathMatch: "full", component: LandingPageComponent },
  { path: 'LandingPage', redirectTo: '' },
  { path: 'Projects', component: ProjectListPageComponent, canActivate: [authGuard] },
  { path: 'Projects/:id', component: ProjectPageComponent, canActivate: [authGuard] },
  { path: 'About-ModelCabinet', component: AboutModelCabinetComponent },
  { path: 'changelog', component: ChangelogComponent },
  { path: `assets`, component: AssetListComponent, canActivate: [authGuard] },
  { path: 'Help', component: HelpProjectComponent },
  { path: 'Assets', component: AssetListComponent, canActivate: [authGuard] },
  { path: 'Assets/:id', component: AssetDetailComponent, canActivate: [authGuard] },
  { path: 'User', component: ProfilePageComponent, canActivate: [authGuard] },
  { path: 'coming-soon', component: ComingSoonComponent },
  { path: 'Edit-Tags', component: TagEditComponent, canActivate: [authGuard] },
  { path: 'login', component: LoginComponent, canActivate: [nonAuthGuard] },
  { path: 'Login', component: LoginComponent, canActivate: [nonAuthGuard] }, // duplicated for case insensitivity
  { path: 'register', component: RegisterComponent, canActivate: [nonAuthGuard] },
  { path: 'Register', component: RegisterComponent, canActivate: [nonAuthGuard] }, // duplicated for case insensitivity
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
