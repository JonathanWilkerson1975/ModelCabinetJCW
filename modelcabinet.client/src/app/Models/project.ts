import { Asset } from "./asset";

export interface projectAsset {
  $values: Asset[]
}
export interface Project {

  projectID: number,
  name: String,
  creationDate: Date,
  modifiedDate: Date,
  description: String,
  author: String,
  version: String,
  assets: projectAsset,
  shortDescription: String,

}
