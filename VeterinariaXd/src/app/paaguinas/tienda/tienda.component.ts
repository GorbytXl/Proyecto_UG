import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-tienda',
  templateUrl: './tienda.component.html',
  styleUrls: ['./tienda.component.css']
})
export class TiendaComponent implements OnInit {
  products = [
    {
      name: 'Medicamento para perros',
      image: 'https://lafarmascota.com/wp-content/uploads/2022/11/desparasitantes.png',
      description: 'Descripción breve del producto 1.'
    },
    {
      name: 'Comida para perros',
      image: 'https://purina.com.ec/sites/default/files/styles/webp/public/2022-11/purina-dog-chow-adultos-todos-los-tama%C3%B1os-con-carne.jpg.webp?itok=NC10NhwX',
      description: 'Descripción breve del producto 2.'
    },
    {
      name: 'Juguetes para perros',
      image: 'https://promart.vteximg.com.br/arquivos/ids/2567338-1000-1000/image-60691779b8da48db800809b00c9c63b0.jpg?v=637705364409200000',
      description: 'Descripción breve del producto 3.'
    },
    // Agrega más productos según sea necesario
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
