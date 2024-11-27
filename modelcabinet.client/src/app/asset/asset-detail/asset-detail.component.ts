import { Component, OnInit } from '@angular/core';
import { Asset } from '../../Models/asset';
import { BehaviorSubject } from 'rxjs';
import { DataService } from '../../data.service';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';

@Component({
  selector: 'app-asset-detail',
  templateUrl: './asset-detail.component.html',
  styleUrl: './asset-detail.component.css'
})
export class AssetDetailComponent implements OnInit {
  assetId = 0;
  asset: BehaviorSubject<Asset>;

  constructor(private route: ActivatedRoute, private data: DataService, private router: Router) {
    this.asset = this.data.asset$;
    this.router.events.subscribe(routeevent => {
      if (routeevent instanceof NavigationEnd) {
        this.getAssetInfo();
      }
    });
  }

  ngOnInit(): void {
    this.getAssetInfo();
  }

  getAssetInfo(): void {
    this.route.paramMap.subscribe(datas => {
      this.assetId = +datas.get('id')!;
    });
    this.data.getAssetsById(this.assetId);
  }
  formatFileSize(size: number): string {
    const byteSizes: number[] = [1000000000000000, 1000000000000, 1000000000, 1000000, 1000];
    //PB
    if (size >= byteSizes[0]) {
      return `${size / byteSizes[0]} PB`;
    } //TB
    else if (size >= byteSizes[1]) {
      return `${size / byteSizes[1]} TB`;
    } //GB
    else if (size >= byteSizes[2]) {
      return `${size / byteSizes[2]} GB`;
    } //MB
    else if (size >= byteSizes[3]) {
      return `${size / byteSizes[3]} MB`;
    } //KB
    else if (size >= byteSizes[4]) {
      return `${size / byteSizes[4]} KB`;
    } //B
    else {
      return `${size} B`;
    }
  }
}
