import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss'],
})
export class ProductsComponent implements OnInit {
  public products: any;

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getProducts();
  }

  public getProducts(): void {
    this.http.get('http://localhost:5281/api/Product/All').subscribe(
      (response) => (this.products = response),
      (error) => console.log(error)
    );
  }
}
