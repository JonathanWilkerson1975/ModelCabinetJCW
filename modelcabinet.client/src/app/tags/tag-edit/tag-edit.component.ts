import { Component, Input, OnInit } from '@angular/core';
import { Tag } from '../../Models/tag';
import { DataService } from '../../data.service';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-tag-edit',
  templateUrl: './tag-edit.component.html',
  styleUrl: './tag-edit.component.css'
})
export class TagEditComponent implements OnInit{
  
  @Input() alltags: Tag[] = [];
  isEditing = false;

  selectedTag: Tag = {
    tagId: -1,
    tagName: "BOGUS DATA",
    color: "000000"
  }

  tagForm: FormGroup = new FormGroup({
    tagName: new FormControl(this.selectedTag.tagName),
    color: new FormControl(this.selectedTag.color)
  });

  constructor(private dataService: DataService) { }

  ngOnInit(): void {
    if (this.alltags.length === 0) {
      this.dataService.tags$.subscribe(tags => {
        this.alltags = tags;
      });
      this.dataService.getAllTags();
    }
    this.clearEdit();
  }

  // Translated from Project-Edit components form code
  onSubmit() {
    if (this.selectedTag == null || !this.tagForm.valid) {
      return;
    }

    const updatedTag: Tag = { ...this.selectedTag, ...this.tagForm.value };

    if (this.isEditing && updatedTag.tagId != null) {
      this.dataService.updateTag(updatedTag);
    }
    else {
      this.dataService.createTag(updatedTag);
    }
  }

  deleteTag(tag: Tag) {
    this.dataService.deleteTag(tag);
  }

  selectTagToEdit(tag: Tag) {
    this.selectedTag = tag;
    this.isEditing = true;
  }

  clearEdit() {
    this.selectedTag = {
      tagId: -1,
      tagName: "BOGUS DATA",
      color: "000000"
    };
    this.isEditing = false;
  }
}
