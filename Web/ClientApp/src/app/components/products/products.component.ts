import { HttpParams } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/models/product';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss'],
  // Podemos injetar a rota da api por aqui, pelo service ou o melhor que eh pelo app.module
  // providers: [ProductService],
})
export class ProductsComponent implements OnInit {
  public products: Product[] = [];
  public filteredProducts: Product[] = [];
  public image: boolean = true;

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

  public listFilteredProduct(filterBy: string): Product[] {
    filterBy = filterBy.toLocaleLowerCase();
    return this.products.filter((product) =>
      product.name.toLocaleLowerCase().includes(filterBy)
    );
  }

  constructor(private productService: ProductService) {}

  public ngOnInit(): void {
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
    const observer = {
      next: (_products: Product[]) => {
        this.products = _products;
        this.filteredProducts = this.products;
        console.log(this.products);
      },
      erro: (error: any) => console.log(error),
      complete: () => {},
    };
    this.productService.getProduct().subscribe(observer);

    // Esse forma abaixo funciona mas gera um alerta no subscribe dizendo que essa forma de usar ficara obsoleto
    // this.productService.getProduct().subscribe(
    //   (products: Product[]) => {
    //     this.products = products;
    //     this.filteredProducts = this.products;
    //   },
    //   (error) => console.log(error)
    // );
  }
}
