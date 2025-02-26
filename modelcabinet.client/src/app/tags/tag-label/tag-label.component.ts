  import { Component, Input } from '@angular/core';
  import { Tag } from '../../Models/tag';

@Component({
  selector: 'app-tag-label',
  templateUrl: './tag-label.component.html',
  styleUrl: './tag-label.component.css'
})
export class TagLabelComponent {
  @Input() tagLabel: Tag = {
    tagId: 0,
    tagName: "BOGUS DATA",
    color:"fc7f7f"
  }
}
