import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-medicacita',
  templateUrl: './medicacita.component.html',
  styleUrls: ['./medicacita.component.css']
})
export class MedicacitaComponent implements OnInit {
  showForm = false;
  showVerification = false;
  formData: any = {};

  ngOnInit(): void {
  }

  toggleForm() {
    this.showForm = !this.showForm;
    this.showVerification = false; // Oculta la verificación al mostrar el formulario
  }

  toggleVerification() {
    this.showVerification = !this.showVerification;
    this.showForm = false; // Oculta el formulario al mostrar la verificación
  }

  onSubmit() {
    this.generateConsultaNumber();
    this.showVerification = true;
  }

  generateConsultaNumber(): void {
    let prefix = '';
    if (this.formData.servicio === 'Veterinaria') {
      prefix = 'V';
    } else if (this.formData.servicio === 'Peluquería') {
      prefix = 'P';
    }
    this.formData.numeroConsulta = prefix + Math.random().toString(36).substr(2, 9).toUpperCase();
  }
}
