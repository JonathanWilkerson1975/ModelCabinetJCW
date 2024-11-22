import { Component, OnInit } from '@angular/core';
import { DataService } from '../../data.service';
import { BehaviorSubject } from 'rxjs';
import { Project } from '../../Models/project';

@Component({
  selector: 'app-project-list-page',
  templateUrl: './project-list-page.component.html',
  styleUrl: './project-list-page.component.css'
})
export class ProjectListPageComponent implements OnInit {
  project$: BehaviorSubject<Project>; 
  projects$: BehaviorSubject<Project[]>;

  constructor(private data: DataService) {
    this.project$ = this.data.project$;
    this.projects$ = this.data.projects$;
  }
  ngOnInit(): void {
    this.data.getAllProjects();
  }

}
