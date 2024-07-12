import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class PersonalService {
  private apiUrl = 'https://localhost:44370/api/veterinaria/GetPersonal';

  constructor(private http: HttpClient) { }

  getPersonal(i_nombre?: string, i_cargo?: string, i_cedula?: string, i_edad?: string): Observable<any> {
    let params = new HttpParams();

    if (i_nombre) params = params.append('i_nombre', i_nombre);
    if (i_cargo) params = params.append('i_cargo', i_cargo);
    if (i_cedula) params = params.append('i_cedula', i_cedula);
    if (i_edad) params = params.append('i_edad', i_edad);

    return this.http.get(this.apiUrl, { params });
  }
}
