import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Navire } from '../models/navire.model';

const baseUrl = 'https://localhost:7024/api/Navires';

@Injectable({
  providedIn: 'root'
})
export class NavireService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<Navire[]> {
    return this.http.get<Navire[]>(baseUrl);
  }

  get(id: any): Observable<Navire> {
    return this.http.get(`${baseUrl}/${id}`);
  }

  create(data: any): Observable<any> {
    return this.http.post(baseUrl, data);
  }

  update(id: any, data: any): Observable<any> {
    return this.http.put(`${baseUrl}/${id}`, data);
  }

  delete(id: any): Observable<any> {
    return this.http.delete(`${baseUrl}/${id}`);
  }

   findByName(name: any): Observable<Navire[]> {
    return this.http.get<Navire[]>(`${baseUrl}?name=${name}`);
  }
  
 
}
