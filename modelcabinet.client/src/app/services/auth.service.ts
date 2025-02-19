import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable, tap, catchError, of } from 'rxjs';
import { LoginDto } from '../Interfaces/login-dto';
import { UserDto } from '../Interfaces/user-dto';
import { RegisterDto } from '../Interfaces/register-dto';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private currentUserSubject = new BehaviorSubject<UserDto | null>(null);
  public currentUser$ = this.currentUserSubject.asObservable();

  constructor(private http: HttpClient) {}

  login(credentials: LoginDto): Observable<UserDto> {
    return this.http.post<UserDto>('/api/auth/login', credentials).pipe(
      tap(user => {
        this.currentUserSubject.next(user);
      })
    );
  }

  register(userData: RegisterDto): Observable<UserDto> {
    return this.http.post<UserDto>('/api/auth/register', userData).pipe(
      tap(user => {
        this.currentUserSubject.next(user);
      })
    );
  }

  logout(): Observable<void> {
    return this.http.post<void>('/api/auth/logout', {}).pipe(
      tap(() => {
        this.currentUserSubject.next(null);
      })
    );
  }

  public loadCurrentUser(): Observable<UserDto | null> {
    return this.http.get<UserDto>('/api/auth/current').pipe(
      tap(user => {
        this.currentUserSubject.next(user);
      }),
      catchError(() => {
        this.currentUserSubject.next(null);
        return of(null);
      })
    );
  }

  get currentUser(): UserDto | null {
    return this.currentUserSubject.value;
  }

  isAuthenticated(): boolean {
    return !!this.currentUserSubject.value;
  }
}
