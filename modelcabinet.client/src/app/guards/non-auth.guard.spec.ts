import { TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { Router, UrlTree, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { nonAuthGuard } from './non-auth.guard';
import { AuthService } from '../services/auth.service';

describe('nonAuthGuard', () => {
  let authService: jasmine.SpyObj<AuthService>;
  let router: Router;
  let dummyRoute: ActivatedRouteSnapshot;
  let dummyState: RouterStateSnapshot;

  beforeEach(() => {
    authService = jasmine.createSpyObj('AuthService', ['isAuthenticated']);
    dummyRoute = {} as ActivatedRouteSnapshot;
    dummyState = { url: '/login' } as RouterStateSnapshot;

    TestBed.configureTestingModule({
      imports: [RouterTestingModule],
      providers: [
        { provide: AuthService, useValue: authService }
      ]
    });

    router = TestBed.inject(Router);
    spyOn(router, 'createUrlTree').and.callThrough();
  });

  it('should allow access when user is not authenticated', () => {
    authService.isAuthenticated.and.returnValue(false);

    const result = TestBed.runInInjectionContext(() => nonAuthGuard(dummyRoute, dummyState));

    expect(result).toBe(true);
    expect(authService.isAuthenticated).toHaveBeenCalled();
    expect(router.createUrlTree).not.toHaveBeenCalled();
  });

  it('should redirect to home when user is authenticated', () => {
    authService.isAuthenticated.and.returnValue(true);
    const mockUrlTree = {} as UrlTree;
    (router.createUrlTree as jasmine.Spy).and.returnValue(mockUrlTree);

    const result = TestBed.runInInjectionContext(() => nonAuthGuard(dummyRoute, dummyState));

    expect(result).toBe(mockUrlTree);
    expect(authService.isAuthenticated).toHaveBeenCalled();
    expect(router.createUrlTree).toHaveBeenCalledWith(['/']);
  });
});
