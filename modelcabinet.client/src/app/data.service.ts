import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { BehaviorSubject } from "rxjs";
import { Project } from "./Models/project";
import { Asset } from "./Models/asset";

@Injectable({
  providedIn:'root'
})

export class DataService {
  projects$: BehaviorSubject<Project[]> = new BehaviorSubject<Project[]>([]);
  project$: BehaviorSubject<Project> = new BehaviorSubject<Project>({
    projectId: 0,
    name: '',
    creationDate: new Date,
    modifiedDate: new Date,
    description: '',
    author: '',
    version: '',
    assets: {$values:[]},
    shortDescription: ''
  });

  assets$: BehaviorSubject<Asset[]> = new BehaviorSubject<Asset[]>([]);
  asset$: BehaviorSubject<Asset> = new BehaviorSubject<Asset>({
    assetId: 0,
    name: '',
    path: '',
    dateCreation: new Date,
    dateUpdated: new Date,
    fileSize: 0,
    projectId: 0,
  });

  constructor(private http: HttpClient) {

  }

  createProject(project: Project) {
    this.http.post<Project>(`/api/Projects`, project).subscribe(data => {
      this.project$.next(data);
      // this.assets$.next(data.asset.&values);
    });
  }

  getAllProjects() {
    this.http.get<Project[]>(`/api/Projects`).subscribe(data => {
      this.projects$.next(data);
    });
  }

  getProjectById(id: number) {
    this.http.get<Project>(`/api/Projects/${id}`).subscribe(data => {
      this.project$.next(data);
      // this.assets$.next(data.asset.&values);
    });
  }

  updateProjectById(id: number, project: Project) {
    this.http.put<Project>(`/api/Projects/${id}`, project).subscribe(data => {
      this.project$.next(data);
      // this.assets$.next(data.asset.&values);
    });
  }

  deleteProjectById(id: number) {
    this.http.delete<Project>(`/api/Projects/${id}`).subscribe(data => {
      this.project$.next(data);
      // this.assets$.next(data.asset.&values);
    });
  }

  createAsset(asset: Asset) {
    this.http.post<Asset>(`/api/Assets`, asset).subscribe(data => {
      this.asset$.next(data);
    });
  }

  getAllAssets() {
    this.http.get<Asset[]>(`/api/Assets`).subscribe(data => {
      this.assets$.next(data);
    });
  }

  getAssetsById(id: number) {
    this.http.get<Asset>(`/api/Assets/${id}`).subscribe(data => {
      this.asset$.next(data);
    })
  }

  updateAssetById(id:number, asset: Asset) {
    this.http.put<Asset>(`/api/Assets`, asset).subscribe(data => {
      this.asset$.next(data);
    });
  }

  deleteAssetById(id: number) {
    this.http.delete<Asset>(`/api/Assets/${id}`).subscribe(data => {
      this.asset$.next(data);
    });
  }
}
