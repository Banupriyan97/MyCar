import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { SaveVehicle } from '../models/Vehicle';

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

  getVehicle(id: number): Observable<any> {
    return this.http.get('https://localhost:7106/api/vehicles/' + id);
  }

  create(vehicle: any): Observable<any> {
    return this.http.post('https://localhost:7106/api/vehicles', vehicle);
  }

  update(vehicle: SaveVehicle): Observable<any> {
    return this.http.put('https://localhost:7106/api/vehicles/' + vehicle.id, vehicle);
  }

  delete(id: number): Observable<any> {
    return this.http.delete('https://localhost:7106/api/vehicles/' + id);
  }

}
