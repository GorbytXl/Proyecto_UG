import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
//inicio del servicio
import { CargarJavascriptService } from './Servicios/cargar-javascript.service';
//Fin del servicio

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HeaderComponent } from './pates/header/header.component';
import { FotterComponent } from './pates/fotter/fotter.component';
import { InicioComponent } from './paaguinas/inicio/inicio.component';
import { LoginComponent } from './paaguinas/login/login.component';
import { TiendaComponent } from './paaguinas/tienda/tienda.component';
import { NavegationComponent } from './pates/navegation/navegation.component';
import { FormsModule } from '@angular/forms';

import { CiopeluComponent } from './pates/ciopelu/ciopelu.component';
import { MedicacitaComponent } from './pates/medicacita/medicacita.component';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FotterComponent,
    InicioComponent,
    LoginComponent,
    TiendaComponent,
    NavegationComponent,
    CiopeluComponent,
    MedicacitaComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FormsModule
  ],
  providers: [
    CargarJavascriptService
  ],
  bootstrap: [AppComponent],

})
export class AppModule { }
