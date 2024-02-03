import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss'],
})
export class ProductsComponent implements OnInit {
  public products: any[] = [];
  public filteredProducts: any = [];
  image: boolean = true;
  private _listFilter: string = '';

  // get eh uma palavra reservada para dizer que o metodo retorna algo
  public get listFilter(): string {
    return this._listFilter;
  }

  // Quando eh set, precisa ter um value
  public set listFilter(value: string) {
    this._listFilter = value;
    this.filteredProducts = this.listFilter
      ? this.listFilteredProduct(this.listFilter)
      : this.products;
  }

  public listFilteredProduct(filterBy: string): any {
    filterBy = filterBy.toLocaleLowerCase();
    return this.products.filter((product) =>
      product.name.toLocaleLowerCase().includes(filterBy)
    );
  }

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getProducts();
  }

  public toggleImage(): void {
    this.image = !this.image;
  }

  public getProducts(): void {
    this.http.get<any[]>('http://localhost:5281/api/Product/All').subscribe(
      (response) => {
        this.products = response;
        this.filteredProducts = this.products;
      },
      (error) => console.log(error)
    );
  }
}
