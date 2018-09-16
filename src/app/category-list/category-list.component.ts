import { DBOperation } from './../shared/DBOperation';
import { Component, OnInit } from '@angular/core';
import { CategoryService } from '../services/category.service';
import { ICategory } from '../models/category';
import { MatTableDataSource, MatSnackBar } from '@angular/material';
import { MatDialog } from '@angular/material';
import { CategoryFormComponent } from '../category-form/category-form.component';

@Component({
    selector: 'app-category-list',
    templateUrl: './category-list.component.html',
    styleUrls: ['./category-list.component.css']
})

export class CategoryListComponent implements OnInit {

    valueSearch = '';
    loadingState: boolean;
    displayedColumns = ['ID', 'Name', 'Description', 'Action'];
    dataSource = new MatTableDataSource<ICategory>();
    categories: ICategory[];
    category: ICategory;
    private categoryUrl = 'api/category/';
    dbop: DBOperation;
    modalTitle: string;
    modalBtnTitle: string;

    constructor(private _categoryService: CategoryService, private dialog: MatDialog, public snackBar: MatSnackBar) { }

    ngOnInit() {
        this.loadingState = true;
        this.LoadData();
    }

    LoadData(): void {
        this._categoryService.GetAllCategories(this.categoryUrl + 'GetAllCategory')
            .subscribe(categories => {
                this.loadingState = false;
                this.dataSource.data = categories;
            });
    }

    addCategory(): void {
        this.dbop = DBOperation.create;
        this.modalTitle = 'Add New Category';
        this.modalBtnTitle = 'Add';
        this.openDialog();
    }

    openDialog(): void {
        const dialogRef = this.dialog.open(CategoryFormComponent, {
            width: '500px',
            data: {
                category: this.category,
                dbop: this.dbop,
                modalTitle: this.modalTitle,
                modalBtnTitle: this.modalBtnTitle
            }
        });

        dialogRef.afterClosed().subscribe(result => {
            console.log('The dialog was closed.');
            if (result === 'success') {
                this.loadingState = true;
                this.LoadData();
                switch (this.dbop) {
                    case DBOperation.create:
                        this.showMessage('Added successfully.');
                        break;
                }

            } else if (result === 'error') {
                this.showMessage('There are some problems when saving. Please contact admin.');
            } else {
                this.showMessage('Please try again. Something went wrong.');
            }
        });
    }

    showMessage(msg: string) {
        this.snackBar.open(msg, '', {
            duration: 3000
        });
    }
}
