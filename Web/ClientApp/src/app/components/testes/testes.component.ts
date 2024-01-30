import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-testes',
  templateUrl: './testes.component.html',
  styleUrls: ['./testes.component.scss'],
})
export class TestesComponent implements OnInit {
  itens: any = [
    {
      name: 'Nome01',
      description: 'Description01',
    },
    {
      name: 'Nome02',
      description: 'Description02',
    },
    {
      name: 'Nome03',
      description: 'Description03',
    },
  ];

  ngOnInit(): void {}
}
