import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss'],
})
export class ProductsComponent implements OnInit {
  public products: any = [
    {
      name: 'Caneca',
      description: 'Linda',
    },
    {
      name: 'Carro',
      description: 'Maravilhoso',
    },
    {
      name: 'Fones',
      description: 'Potentes',
    },
  ];

  ngOnInit(): void {}
}
