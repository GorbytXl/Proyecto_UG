
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { InicioComponent } from './paaguinas/inicio/inicio.component';
import { TiendaComponent } from './paaguinas/tienda/tienda.component';
import { LoginComponent } from './paaguinas/login/login.component';
import { CiopeluComponent } from './pates/ciopelu/ciopelu.component';
import { MedicacitaComponent } from './pates/medicacita/medicacita.component';



const routes: Routes = [
  { path: '', redirectTo: '/inicio', pathMatch: 'full' },
  { path: 'inicio', component: InicioComponent },
  { path: 'tienda', component: TiendaComponent },
  { path: 'login', component: LoginComponent },
  { path: 'citaopelu', component: CiopeluComponent },
  { path: 'medicina', component: MedicacitaComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
