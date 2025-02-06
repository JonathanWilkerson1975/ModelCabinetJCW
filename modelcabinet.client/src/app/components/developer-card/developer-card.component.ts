import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

interface Developer {
  login: string;
  avatar_url: string;
  html_url: string;
}

@Component({
  selector: 'app-developer-card',
  templateUrl: './developer-card.component.html',
  styleUrl: './developer-card.component.css'
})
export class DeveloperCardComponent implements OnInit {
  developers: Developer[] = [];

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.fetchContributors();
  }

  fetchContributors(): void {
    const apiUrl = 'https://api.github.com/repos/CCAppDevs/ModelCabinet/contributors';

    this.http.get<Developer[]>(apiUrl).subscribe(
      (data) => {
        this.developers = data;
      },
      (error) => {
        console.error('Error fetching contributors', error);
      }
    );
  }
}
