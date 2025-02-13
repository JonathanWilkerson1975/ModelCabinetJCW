import { Component, OnInit } from '@angular/core';
import { ChangelogService } from '../services/changelog.service';
import { Commit } from '../services/changelog.service';

@Component({
  selector: 'app-changelog',
  templateUrl: './changelog.component.html',
  styleUrl: './changelog.component.css'
})

export class ChangelogComponent implements OnInit {
  commits: Commit[] = [];
  loading = true;

  constructor(private changelogService: ChangelogService) { }

  ngOnInit(): void {
    this.changelogService.getChangelog().subscribe({
      next: (data) => {
        this.commits = data;
        this.loading = false;
      },
      error: (err) => {
        console.error('Error fetching changelog:', err);
        this.loading = false;
      }
    });
  }
}
