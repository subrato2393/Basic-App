import { Component, OnInit } from '@angular/core';
import { ProductService } from '../../services/product.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {

  productList:any;
  constructor(private productService:ProductService) { }

  ngOnInit(): void {
    this.getAllProductList();
  }
  
  getAllProductList(){
    this.productService.getAll().subscribe((res)=>{
      this.productList =res;
      console.log(this.productList);
    }
    )
  }
}
