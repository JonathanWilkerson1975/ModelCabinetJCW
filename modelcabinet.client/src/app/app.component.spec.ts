import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { ComponentFixture, TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { AppComponent } from './app.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { DataService } from './data.service';

describe('AppComponent', () => {
  let component: AppComponent;
  let fixture: ComponentFixture<AppComponent>;
  let httpMock: HttpTestingController;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AppComponent, NavBarComponent],
      imports: [HttpClientTestingModule, RouterTestingModule],
      providers: [DataService]
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppComponent);
    component = fixture.componentInstance;
    httpMock = TestBed.inject(HttpTestingController);
  });

  afterEach(() => {
    httpMock.verify();
  });

  it('should create the app', () => {
    expect(component).toBeTruthy();
  });

  it('should mock API call', () => {

    fixture.detectChanges();

    const req = httpMock.expectOne('/api/auth/current');
    expect(req.request.method).toBe('GET');

    req.flush({ user: { id: 1, name: 'Test User' } })

  });

  it('render nav-bar', async () => {

    const compiled = fixture.nativeElement;
    expect(compiled.querySelector('nav-bar')).toBeDefined();
  });

  //it('should retrieve weather forecasts from the server', () => {
  //  const mockForecasts = [
  //    { date: '2021-10-01', temperatureC: 20, temperatureF: 68, summary: 'Mild' },
  //    { date: '2021-10-02', temperatureC: 25, temperatureF: 77, summary: 'Warm' }
  //  ];

  //  component.ngOnInit();

  //  const req = httpMock.expectOne('/weatherforecast');
  //  expect(req.request.method).toEqual('GET');
  //  req.flush(mockForecasts);

  //  expect(component.forecasts).toEqual(mockForecasts);
  //});

});

