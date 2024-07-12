import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router'; // Importa Router

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  username: string = '';
  password: string = '';
  errorMessage: string = '';

  private readonly validUsername: string = 'admin';
  private readonly validPassword: string = 'password123';

  constructor(private router: Router) { }

  ngOnInit(): void { }

  onSubmit(): void {
    if (this.username === this.validUsername && this.password === this.validPassword) {
      alert('Login exitoso');
      this.router.navigate(['/citaopelu'], { queryParams: { username: this.username } });
    } else {
      this.errorMessage = 'Usuario o contraseña incorrectos';
      this.username = '';
      this.password = '';
    }
  }
}
