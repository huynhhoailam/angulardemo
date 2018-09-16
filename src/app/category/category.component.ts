import { Component, OnInit } from '@angular/core';
import { CategoryService } from '../services/category.service';
import { ICategory } from '../models/category';
import { MatTableDataSource, MatSnackBar } from '@angular/material';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';

@Component({
    selector: 'app-category',
    templateUrl: './category.component.html',
    styleUrls: ['./category.component.css']
})

export class CategoryComponent implements OnInit {

    loadingState: boolean;
    columns = ['ID', 'Name', 'Description', 'Action'];
    dataSource = new MatTableDataSource<ICategory>();
    categories: ICategory[];
    category: ICategory;
    private categoryUrl = 'api/category/';

    constructor(private _categoryService: CategoryService) {}

    ngOnInit() {
        this.loadingState = true;
        this.LoadData();
    }

    LoadData(): void {
        this._categoryService.GetAllCategories(this.categoryUrl + 'GetAllCategory')
        .subscribe(c => this.categories = c);
    }

    addCategory(): void {

    }
}
