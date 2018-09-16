import { AppMaterialModule } from './app.material.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { CategoryListComponent } from './category-list/category-list.component';
import { ProductComponent } from './product/product.component';
import { Routing } from './app.routing';
import { HttpClientModule } from '@angular/common/http';
import { CategoryService } from './services/category.service';
import { CategoryFormComponent } from './category-form/category-form.component';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
@NgModule({
  declarations: [
    AppComponent,
    CategoryFormComponent,
    ProductComponent,
    CategoryListComponent
  ],
  imports: [
    BrowserModule,
    Routing,
    HttpClientModule,
    AppMaterialModule,
    FormsModule,
    BrowserAnimationsModule
  ],
  providers: [CategoryService],
  bootstrap: [AppComponent]
})
export class AppModule { }
