import { Component } from '@angular/core';

@Component({
  selector: 'app-changelog',
  templateUrl: './changelog.component.html',
  styleUrl: './changelog.component.css'
})
export class ChangelogComponent {

  // Mock data
  changelog = [
    {
      version: '0.0.2',
      date: '2024-11-24',
      changes: [
        { type: 'Added', description: 'New landing page' },
        { type: 'Fixed', description: 'Resolved issue with navbar' },
        { type: 'Updated', description: 'Updated list of contributors and roles' }
      ]
    },
    {
      version: '0.0.1',
      date: '2024-11-10',
      changes: [
        { type: 'Added', description: 'Launched web app' }
      ]
    }
  ];

  activeIndex: number | null = null;

  toggleAccordion(index: number): void {
    this.activeIndex = this.activeIndex === index ? null : index;
  }
}
