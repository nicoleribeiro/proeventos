import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  // exemplo de objeto em typescript
  // any pq nao tem tipo definido
  // public eventos: any = [
  //   {
  //     Tema: 'Angular',
  //     Local: 'São Paulo'
  //   },
  //   {
  //     Tema: '.NET',
  //     Local: 'Rio de Janeiro'
  //   },
  //   {
  //     Tema: 'Angular e suas novidades',
  //     Local: 'Belo Horizonte'
  //   }
  // ]

  public eventos: any;

  constructor(private http: HttpClient) { }

  // ngOnInit chama ao iniciar a aplicação
  ngOnInit(): void {
    this.getEventos();
  }

  // método get
  public getEventos():void{
    // objeto com dados vindos da api
    this.http.get('https://localhost:5001/api/eventos').subscribe(
      response => this.eventos = response,
      error => console.log(error)
    );

    // objeto com dados estáticos
    // this.eventos = [
    //   {
    //     Tema: 'Angular',
    //     Local: 'São Paulo'
    //   },
    //   {
    //     Tema: '.NET',
    //     Local: 'Rio de Janeiro'
    //   },
    //   {
    //     Tema: 'Angular e suas novidades',
    //     Local: 'Belo Horizonte'
    //   }
    // ]
  }
}
