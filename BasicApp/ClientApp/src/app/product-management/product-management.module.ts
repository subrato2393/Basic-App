import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductManagementRoutingModule } from './product-management-routing.module';
import { NewProductComponent } from './product/new-product/new-product.component';
import { ProductListComponent } from './product/product-list/product-list.component';

@NgModule({
  declarations: [
    NewProductComponent,
    ProductListComponent
  ],
  imports: [
    CommonModule,
    ProductManagementRoutingModule
  ]
})
export class ProductManagementModule { }
