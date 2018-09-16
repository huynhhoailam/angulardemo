import { AppMaterialModule } from './app.material.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { CategoryComponent } from './category/category.component';
import { ProductComponent } from './product/product.component';
import { Routing } from './app.routing';
import { HttpClientModule } from '@angular/common/http';
import { CategoryService } from './services/category.service';
import { CreateCategoryComponent } from './category/create-category/create-category.component';
import { FormsModule } from '@angular/forms';
@NgModule({
  declarations: [
    AppComponent,
    CategoryComponent,
    ProductComponent,
    CreateCategoryComponent
  ],
  imports: [
    BrowserModule,
    Routing,
    HttpClientModule,
    AppMaterialModule,
    FormsModule
  ],
  providers: [CategoryService],
  bootstrap: [AppComponent]
})
export class AppModule { }
