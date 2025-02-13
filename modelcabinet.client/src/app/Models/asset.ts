import { Tag } from "./tag";

export interface Asset {
  assetId: number,
  name: string,
  path: string,
  dateCreation: Date,
  dateUpdated: Date,
  fileSize: number, 
  projectId: number,
  assetTags: Tag[]
}
