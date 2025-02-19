import { TestBed } from '@angular/core/testing';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { AuthService } from './auth.service';
import { LoginDto } from '../Interfaces/login-dto';
import { UserDto } from '../Interfaces/user-dto';
import { RegisterDto } from '../Interfaces/register-dto';

describe('AuthService', () => {
  let service: AuthService;
  let httpMock: HttpTestingController;

  // Mock response data (UserDto)
  const mockUserResponse: UserDto = {
    id: '1',
    email: 'test@example.com',
    displayName: 'Test User',
    biography: 'Test bio',
    location: 'Test location',
    website: 'http://test.com',
    avatarUrl: 'http://test.com/avatar.jpg',
    twitterHandle: 'testuser',
    githubUsername: 'testuser',
    preferredLanguage: 'en',
    timeZone: 'UTC',
    dateJoined: new Date(),
    lastActive: new Date(),
    isProfilePublic: true,
    emailNotificationsEnabled: true,
    projectUpdatesEnabled: true,
    newMessageNotificationsEnabled: true
  };

  // Mock login request data (LoginDto)
  const mockLoginRequest: LoginDto = {
    email: 'test@example.com',
    password: 'testPassword123!',
    rememberMe: true
  };

  // Mock register request data (RegisterDto)
  const mockRegisterRequest: RegisterDto = {
    email: 'test@example.com',
    password: 'testPassword123!',
    confirmPassword: 'testPassword123!',
    displayName: 'Test User'
  };

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [AuthService]
    });

    service = TestBed.inject(AuthService);
    httpMock = TestBed.inject(HttpTestingController);
  });

  afterEach(() => {
    httpMock.verify();
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  describe('login', () => {
    it('should authenticate user and update current user subject', () => {
      service.login(mockLoginRequest).subscribe(user => {
        expect(user).toEqual(mockUserResponse);
        expect(service.currentUser).toEqual(mockUserResponse);
      });

      const loginReq = httpMock.expectOne('/api/auth/login');
      expect(loginReq.request.method).toBe('POST');
      loginReq.flush(mockUserResponse);
    });
  });

  describe('register', () => {
    it('should register user and update current user subject', () => {
      service.register(mockRegisterRequest).subscribe(user => {
        expect(user).toEqual(mockUserResponse);
        expect(service.currentUser).toEqual(mockUserResponse);
      });

      const registerReq = httpMock.expectOne('/api/auth/register');
      expect(registerReq.request.method).toBe('POST');
      registerReq.flush(mockUserResponse);
    });
  });

  describe('logout', () => {
    it('should clear current user on logout', () => {
      service.logout().subscribe(() => {
        expect(service.currentUser).toBeNull();
      });

      const logoutReq = httpMock.expectOne('/api/auth/logout');
      expect(logoutReq.request.method).toBe('POST');
      logoutReq.flush({ message: 'Logged out successfully' });
    });
  });

  describe('loadCurrentUser', () => {
    it('should load current user successfully', () => {
      service.loadCurrentUser().subscribe(user => {
        expect(user).toEqual(mockUserResponse);
        expect(service.currentUser).toEqual(mockUserResponse);
      });

      const req = httpMock.expectOne('/api/auth/current');
      expect(req.request.method).toBe('GET');
      req.flush(mockUserResponse);
    });

    it('should handle error and set current user to null', () => {
      service.loadCurrentUser().subscribe(user => {
        expect(user).toBeNull();
        expect(service.currentUser).toBeNull();
      });

      const req = httpMock.expectOne('/api/auth/current');
      req.error(new ErrorEvent('Network error'));
    });
  });

  describe('isAuthenticated', () => {
    it('should return true when user is logged in', () => {
      service['currentUserSubject'].next(mockUserResponse);
      expect(service.isAuthenticated()).toBeTrue();
    });

    it('should return false when no user is logged in', () => {
      service['currentUserSubject'].next(null);
      expect(service.isAuthenticated()).toBeFalse();
    });
  });
});
