import { Asset } from "./asset";

export interface Project {

  projectId: number,
  name: string,
  creationDate: Date,
  modifiedDate: Date,
  description: string,
  author: string,
  version: string,
  assets: Asset[],
  shortDescription: string,
  slug: string,

}
