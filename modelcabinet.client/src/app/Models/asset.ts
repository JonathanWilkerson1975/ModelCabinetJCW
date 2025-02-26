import { Tag } from "./tag";

export interface Asset {
  assetId: number,
  name: string,
  path: string,
  dateCreation: Date,
  dateUpdated: Date,
  fileSize: number, 
  projectId: number,
  assetTags: AssetTag[]
}

// Used to Match the structure in the backend
export interface AssetTag {
  assetId: number,
  tagId: number,
  asset: Asset,
  tag: Tag
}
