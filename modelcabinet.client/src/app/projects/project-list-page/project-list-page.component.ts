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
  projects$: BehaviorSubject<Project[]>;
  currentPage$: BehaviorSubject<number>;    // Current page number
  totalPages$: BehaviorSubject<number>;     // Total available pages
  loading: boolean = false;                 // Track loading status


  constructor(private data: DataService) {
    this.projects$ = this.data.projects$;
    this.currentPage$ = this.data.currentPage$;
    this.totalPages$ = this.data.totalPages$;
  }

  ngOnInit(): void {
    this.loadPage(1);
  }

  loadPage(page: number) {
    this.loading = true; // Start with loading spinner on

    if (page < 1) return;

    this.data.getAllProjects(page).subscribe(
      (data) => {
        this.projects$.next(data.projects);
        this.loading = false;
      },
      (error) => {
        console.error('Error loading projects:', error);
        this.loading = false;
      }
    );
  }

  nextPage() {
    this.loadPage(this.data.currentPage$.value + 1);
  }

  previousPage() {
    this.loadPage(this.data.currentPage$.value - 1);
  }
}
