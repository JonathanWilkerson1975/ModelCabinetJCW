import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HelpProjectComponent } from './Help-Page.component';

describe('HelpProjectComponent', () => {
  let component: HelpProjectComponent;
  let fixture: ComponentFixture<HelpProjectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [HelpProjectComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HelpProjectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
