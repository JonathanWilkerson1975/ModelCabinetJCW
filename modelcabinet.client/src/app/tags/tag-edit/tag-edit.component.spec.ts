import { ComponentFixture, TestBed } from '@angular/core/testing';
import { TagEditComponent } from './tag-edit.component';
import { DataService } from '../../data.service';
import { of } from 'rxjs';
import { ReactiveFormsModule } from '@angular/forms';

describe('TagEditComponent', () => {
  let component: TagEditComponent;
  let fixture: ComponentFixture<TagEditComponent>;
  let mockDataService: jasmine.SpyObj<DataService>;


  beforeEach(async () => {
    // Create a mock DataService with spies
    mockDataService = jasmine.createSpyObj('DataService', [
      'getAllTags',
      'updateTag',
      'createTag',
      'deleteTag'
    ]);

    // Ensure `tags$` is properly mocked as an observable
    Object.defineProperty(mockDataService, 'tags$', { get: () => of([]) });

    await TestBed.configureTestingModule({
      imports: [ReactiveFormsModule], // Required for FormGroup and FormControl
      declarations: [TagEditComponent],
      providers: [
        { provide: DataService, useValue: mockDataService } // Provide Mocking DataService
      ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TagEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
