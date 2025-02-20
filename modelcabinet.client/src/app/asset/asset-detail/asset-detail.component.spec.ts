import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AssetDetailComponent } from './asset-detail.component';
import { RouterTestingModule } from '@angular/router/testing';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { FileSizePipe } from '../../Pipes/file-size.pipe';
import { DataService } from '../../data.service';

describe('AssetDetailComponent', () => {
  let component: AssetDetailComponent;
  let fixture: ComponentFixture<AssetDetailComponent>;

  // create the mock service
  let mockDataService = jasmine.createSpyObj(['getAllAssets']);

  beforeEach(async () => {
    // global arrange

    // To specify the value returned by a mock service:
    // mockDataService.getAllAssets.and.returnValue('toast');

    await TestBed.configureTestingModule({
      declarations: [
        AssetDetailComponent,
        FileSizePipe,
      ],
      providers: [
        { provide: DataService, useValue: mockDataService }
      ],
      imports: [
        RouterTestingModule.withRoutes([]),
        HttpClientTestingModule
      ]
    })
    .compileComponents();



    fixture = TestBed.createComponent(AssetDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    // arrange more
    expect(component).toBeTruthy();
  });

  it('should call DataService.getAllAssets()', () => {
    expect(mockDataService.getAllAssets).toHaveBeenCalled();
    // expect(component.dataGatheredByMockService).toEqual('blah');
  });

});
