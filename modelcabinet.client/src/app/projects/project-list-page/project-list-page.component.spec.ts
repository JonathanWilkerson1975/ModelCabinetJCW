import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectListPageComponent } from './project-list-page.component';

describe('ProjectListPageComponent', () => {
  let component: ProjectListPageComponent;
  let fixture: ComponentFixture<ProjectListPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ProjectListPageComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProjectListPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
