import { Component, Input } from '@angular/core';
import { Asset } from '../../Models/asset';
import { DataService } from '../../data.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-asset-detail',
  templateUrl: './asset-detail.component.html',
  styleUrl: './asset-detail.component.css'
})
export class AssetDetailComponent {

  @Input() asset: Asset = {
    assetId: 0,
    name: '',
    path: '',
    dateCreation: new Date(),
    dateUpdated: new Date(),
    fileSize: 0,
    projectId: 0
  };

  constructor(private route: ActivatedRoute, private data: DataService, private router: Router) {

  }
}
