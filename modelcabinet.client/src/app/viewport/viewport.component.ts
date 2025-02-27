import { ChangeDetectionStrategy, ChangeDetectorRef, Component, ElementRef, Input, NgZone, OnInit } from '@angular/core';
import { Asset } from '../Models/asset';
import { StlModelViewerComponent } from 'angular-stl-model-viewer';

// @ts-ignore
import * as THREE from 'three';

@Component({
  selector: 'app-viewport',
  templateUrl: './viewport.component.html',
  styleUrl: './viewport.component.css',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ViewportComponent extends StlModelViewerComponent implements OnInit {
  constructor(private _cdr: ChangeDetectorRef, private _eleRef: ElementRef, private _ngZone: NgZone) {
    super(_cdr, _eleRef, _ngZone);
    
  }

}
