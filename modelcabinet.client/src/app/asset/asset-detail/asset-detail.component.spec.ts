import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AssetDetailComponent } from './asset-detail.component';
import { RouterTestingModule } from '@angular/router/testing';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { FileSizePipe } from '../../Pipes/file-size.pipe';

describe('AssetDetailComponent', () => {
  let component: AssetDetailComponent;
  let fixture: ComponentFixture<AssetDetailComponent>;

  // TODO: fix for spying on data object - let spyData = jasmine.createSpyObj('DataService', ['getAllAssets']);

  beforeEach(async () => {
    // global arrange
    await TestBed.configureTestingModule({
      declarations: [
        AssetDetailComponent,
        FileSizePipe,
        
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

});
