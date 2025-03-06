import { Component } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { Router } from '@angular/router';
import { finalize } from 'rxjs/operators';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent {
  isLoggingOut = false;

  constructor(private authService: AuthService, private router: Router) { }

  isAuthenticated(): boolean {
    return this.authService.isAuthenticated(); 
  }

  logout(): void {
    console.log('Logout process initiated');
    this.isLoggingOut = true;

    this.authService.logout().pipe(
      finalize(() => this.isLoggingOut = false)
    ).subscribe({
      next: () => {
        // redirect to homepage
        this.router.navigate(['/']);
      },
      error: (error) => {
        console.error('Logout error:', error);
        // if error, redirect anyway
        this.router.navigate(['/']);
      }
    })
  }
  
  onSearch(event: Event): void {
    event.preventDefault(); 
    this.router.navigate(['/coming-soon']); 
  }

}
