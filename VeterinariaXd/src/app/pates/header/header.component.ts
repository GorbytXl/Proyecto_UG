import { CargarJavascriptService } from './../../Servicios/cargar-javascript.service';
import { Component, OnInit } from '@angular/core';
declare function toggleMenu(): void;

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor(private cargarjava:CargarJavascriptService) {
    cargarjava.Carga(["src/assets/js/toggleMenu.js"]);
  }

  ngOnInit(): void {
  }
  public onToggleMenu(): void {
    toggleMenu();
  }

}
