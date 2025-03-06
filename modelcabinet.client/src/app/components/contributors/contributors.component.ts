

import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { catchError } from 'rxjs/operators';
import { throwError } from 'rxjs';

interface Developer {
  login: string;
  avatar_url: string;
  html_url: string;
}

@Component({
  selector: 'app-contributors',
  templateUrl: './contributors.component.html',
  styleUrls: ['./contributors.component.css']
})
export class ContributorsComponent implements OnInit {
  contributors: Developer[] = [];

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.http.get<Developer[]>('https://api.github.com/repos/CCAppDevs/ModelCabinet/contributors')
      .pipe(
        catchError(this.handleError)  
      )
      .subscribe(
        data => {
          this.contributors = data;
        } 
      );
  }

  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      
      console.error('An error occurred:', error.error.message);
    } else {
      
      console.error(`Backend returned code ${error.status}, ` +
        `body was: ${error.error}`);
    }
    
    return throwError('Something bad happened; please try again later.');
  }
}
