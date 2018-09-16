import { CategoryService } from './../services/category.service';
import { FormBuilder } from '@angular/forms';
import { CategoryListComponent } from './../category-list/category-list.component';
import { Component, OnInit, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material';

@Component({
  selector: 'app-category-form',
  templateUrl: './category-form.component.html',
  styleUrls: ['./category-form.component.css']
})
export class CategoryFormComponent implements OnInit {

  constructor() { }

  ngOnInit() { }

}
