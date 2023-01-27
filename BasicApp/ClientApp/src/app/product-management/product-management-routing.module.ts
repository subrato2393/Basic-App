import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NewProductComponent } from './product/new-product/new-product.component';
import { ProductListComponent } from './product/product-list/product-list.component';

const routes: Routes = [
  { 
    path:  '',
    redirectTo:'product-management',
    pathMatch: 'full', 
  },
  { 
    path: 'product-list', 
    component: ProductListComponent 
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProductManagementRoutingModule { }
