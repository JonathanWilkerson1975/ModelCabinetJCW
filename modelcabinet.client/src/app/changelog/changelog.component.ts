import { Component, OnInit } from '@angular/core';
import { ChangelogService } from '../services/changelog.service';
import { Commit } from '../services/changelog.service';

@Component({
  selector: 'app-changelog',
  templateUrl: './changelog.component.html',
  styleUrl: './changelog.component.css'
})

export class ChangelogComponent implements OnInit {
  commits: Commit[] = []; // Array to hold commit data
  loading: boolean = true; // To show a loading indicator

  constructor(private changelogService: ChangelogService) { }

  ngOnInit(): void {
    // Fetch changelog data on component initialization
    this.changelogService.getChangelog().subscribe({
      next: (data) => {
        this.commits = data; // Assign data to the commits array
        this.loading = false; // Turn off loading indicator
      },
      error: (err) => {
        console.error('Error fetching changelog:', err);
        this.loading = false; // Turn off loading indicator even if there's an error
      }
    });
  }
}
//export class ChangelogComponent {

//  // Mock data
//  changelog = [
//    {
//      version: '0.0.2',
//      date: '2024-11-24',
//      changes: [
//        { type: 'Added', description: 'New landing page' },
//        { type: 'Fixed', description: 'Resolved issue with navbar' },
//        { type: 'Updated', description: 'Updated list of contributors and roles' }
//      ]
//    },
//    {
//      version: '0.0.1',
//      date: '2024-11-10',
//      changes: [
//        { type: 'Added', description: 'Launched web app' }
//      ]
//    }
//  ];

//  activeIndex: number | null = null;

//  toggleAccordion(index: number): void {
//    this.activeIndex = this.activeIndex === index ? null : index;
//  }
//}
