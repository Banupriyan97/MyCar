import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class VehicleService {

  constructor(private http: HttpClient) { }

  getMakes(): Observable<any> {
    return this.http.get('https://localhost:7106/api/makes');
  }

  getFeatures(): Observable<any> {
    return this.http.get('https://localhost:7106/api/features');
  }
  
}
