import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Commit {
  sha: string;
  commit: {
    author: {
      name: string;
      email: string;
      date: string;
    };
    message: string;
  };
  url: string;
}

@Injectable({
  providedIn: 'root'
})
export class ChangelogService {
  private apiUrl = 'https://api.github.com/repos/CCAppDevs/ModelCabinet/commits?sha=development';

  constructor(private http: HttpClient) { }

  getChangelog(): Observable<Commit[]> {
    return this.http.get<Commit[]>(this.apiUrl);
  }
}

