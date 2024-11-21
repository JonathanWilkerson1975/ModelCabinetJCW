import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ChangelogService {
  private apiUrl = 'https://github.com/CCAppDevs/ModelCabinet/commits/development/';

  constructor(private http: HttpClient) { }

  getChangelog(): Observable<any> {
    return this.http.get<any>(this.apiUrl);
  }
}