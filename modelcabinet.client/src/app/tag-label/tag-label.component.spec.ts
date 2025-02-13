import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TagLabelComponent } from './tag-label.component';

describe('TagLabelComponent', () => {
  let component: TagLabelComponent;
  let fixture: ComponentFixture<TagLabelComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TagLabelComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TagLabelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
