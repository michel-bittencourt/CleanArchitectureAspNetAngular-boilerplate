import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss'],
  // Podemos injetar a rota da api por aqui, pelo service ou o melhor que eh pelo app.module
  // providers: [ProductService],
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

  constructor(private productService: ProductService) {}

  ngOnInit(): void {
    this.getProducts();
  }

  public toggleImage(): void {
    this.image = !this.image;
  }

  public checkProductExists(): boolean {
    if (this.products.length) {
      return true;
    }
    return false;
  }

  public getProducts(): void {
    this.productService.getProduct().subscribe(
      (response: any) => {
        this.products = response;
        this.filteredProducts = this.products;
      },
      (error: any) => console.log(error)
    );
  }
}
