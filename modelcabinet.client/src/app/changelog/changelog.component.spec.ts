import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChangelogComponent } from './changelog.component';
import { HttpClientTestingModule } from '@angular/common/http/testing';

describe('ChangelogComponent', () => {
  let component: ChangelogComponent;
  let fixture: ComponentFixture<ChangelogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [
        ChangelogComponent
      ],
      imports: [
        HttpClientTestingModule
      ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ChangelogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
