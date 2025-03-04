import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TagLabelComponent } from './tag-label.component';
import { Tag } from '../../Models/tag';

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

    const tagData: Tag = {
      tagId: 1,
      tagName: 'Testing',
      color: 'fc7f7f'
    }
    component.tagLabel = tagData;

    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
