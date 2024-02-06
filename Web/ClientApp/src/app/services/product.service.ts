import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable(
  // Podemos injetar a rota da api por aqui, pelo model ou o melhor que eh pelo app.module
  // {providedIn: 'root'}
  )
export class ProductService {
  private baseUrl: string = 'http://localhost:5281/api/Product';
  constructor(private http: HttpClient) {}

  getProduct() {
    return this.http.get(this.baseUrl);
  }
}
