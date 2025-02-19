import { Component, Input } from '@angular/core';
import { Tag } from '../Models/tag';

@Component({
  selector: 'app-tag-label',
  templateUrl: './tag-label.component.html',
  styleUrl: './tag-label.component.css'
})
export class TagLabelComponent {
  @Input() tag: Tag = {
    tagId: 0,
    tagName: "",
    color:"000000",
    projectTags: [],
    assetTags: []
  }
}
