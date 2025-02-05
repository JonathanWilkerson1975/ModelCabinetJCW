import { Component, OnInit } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Project } from '../../Models/project';
import { DataService } from '../../data.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-project-page',
  templateUrl: './project-page.component.html',
  styleUrl: './project-page.component.css'
})
export class ProjectPageComponent implements OnInit {
  projid = 0;
  project: BehaviorSubject<Project>;

  constructor(private route: ActivatedRoute, private data: DataService, private router: Router) {
    this.project = this.data.project$;
  }

  getProjectData(): void {
    this.route.paramMap.subscribe(data => {
      this.projid = +data.get('id')!;
      this.data.getProjectById(this.projid);
      console.log(this.project, this.projid);
    });
  }

  ngOnInit(): void {
    this.getProjectData();
  }
}
