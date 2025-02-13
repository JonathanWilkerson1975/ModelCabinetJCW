import { Asset } from "./asset";
import { Project } from "./project";

export interface Tag {
  tagId: number,
  tagName: string,
  assetTags: Asset[],
  projectTags: Project[]
}
