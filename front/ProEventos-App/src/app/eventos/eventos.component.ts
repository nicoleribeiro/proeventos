import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  // exemplo de objeto em typescript
  // any pq nao tem tipo definido
  public eventos: any = [
    {
      Tema: 'Angular',
      Local: 'São Paulo'
    },
    {
      Tema: '.NET',
      Local: 'Rio de Janeiro'
    },
    {
      Tema: 'Angular e suas novidades',
      Local: 'Belo Horizonte'
    }
  ]

  constructor() { }

  ngOnInit(): void {
  }

}
