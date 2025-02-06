import { Component } from '@angular/core';

@Component({
  selector: 'app-about-project',
  templateUrl: './about-project.component.html',
  styleUrl: './about-project.component.css'
})
export class AboutProjectComponent {
  developers = [
    { name: 'Brittany H', image: 'assets/images/dev_placeholder.png' },
    { name: 'Clarissa L', image: 'assets/images/dev_placeholder.png' },
    { name: 'Colton S', image: 'assets/images/dev_placeholder.png' },
    { name: 'Connor G', image: 'assets/images/dev_placeholder.png' },
    { name: 'Jesse H', image: 'assets/images/dev_placeholder.png' },
    { name: 'Jonathan W', image: 'assets/images/dev_placeholder.png' },
    { name: 'Jude M', image: 'assets/images/dev_placeholder.png' },
    { name: 'Juliea R', image: 'assets/images/dev_placeholder.png' },
    { name: 'Kathy Y', image: 'assets/images/dev_placeholder.png' },
    { name: 'Khai H', image: 'assets/images/dev_placeholder.png' },
    { name: 'Lee H', image: 'assets/images/dev_placeholder.png' },
    { name: 'Sarah H', image: 'assets/images/dev_placeholder.png' },
    { name: 'William R', image: 'assets/images/dev_placeholder.png' }];
}
