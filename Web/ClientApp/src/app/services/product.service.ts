import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from '../models/product';

@Injectable()
// Podemos injetar a rota da api por aqui, pelo model ou o melhor que eh pelo app.module
// {providedIn: 'root'}
export class ProductService {
  private baseUrl: string = 'http://localhost:5281/api/Product';
  constructor(private http: HttpClient) {}

  getProduct(): Observable<Product[]> {
    return this.http.get<Product[]>(this.baseUrl);
  }

  getProductById(id: number): Observable<Product> {
    return this.http.get<Product>(`${this.baseUrl}/${id}`);
  }
}
