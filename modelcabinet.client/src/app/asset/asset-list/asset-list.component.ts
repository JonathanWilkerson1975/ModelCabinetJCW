import { Component, OnInit } from "@angular/core";
import { BehaviorSubject } from "rxjs";
import { Asset } from "../../Models/asset";
import { DataService } from "../../data.service";

@Component({
  selector: 'app-asset-list',
  templateUrl: './asset-list.component.html',
  styleUrl: './asset-list.component.css'
})

export class AssetListComponent implements OnInit {
  assets: BehaviorSubject<Asset[]>;

  constructor(private data:DataService) {
    this.assets = this.data.assets$;
  }
  ngOnInit(): void {
    this.data.getAllAssets();
  }

  formatFileSize(size: number): string {
   const byteSizes: number[] = [1000000000000000,1000000000000,1000000000,1000000,1000]; 
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
