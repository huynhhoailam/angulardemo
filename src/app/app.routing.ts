import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule, Router } from '@angular/router';

import { AppComponent } from './app.component';
import { CategoryComponent } from './category/category.component';
import { ProductComponent } from './product/product.component';

const appRoutes: Routes = [
    {path: '', pathMatch: 'full', redirectTo: ''},
    {path: 'category', component: CategoryComponent},
    {path: 'product', component: ProductComponent}
];

export const Routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);
