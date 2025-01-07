import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { SaveVehicle } from '../models/Vehicle';

@Injectable({
  providedIn: 'root'
})
export class VehicleService {
  private readonly vehiclesEndPoint = 'https://localhost:7106/api/vehicles';

  constructor(private http: HttpClient) { }

  getMakes(): Observable<any> {
    return this.http.get('https://localhost:7106/api/makes');
  }

  getFeatures(): Observable<any> {
    return this.http.get('https://localhost:7106/api/features');
  }

  getVehicle(id: number): Observable<any> {
    return this.http.get(this.vehiclesEndPoint + '/' + id);
  }

  getVehicles(filter: any): Observable<any> {
    return this.http.get(this.vehiclesEndPoint + '?' + this.toQueryString(filter));
  }

  create(vehicle: any): Observable<any> {
    return this.http.post(this.vehiclesEndPoint, vehicle);
  }

  update(vehicle: SaveVehicle): Observable<any> {
    return this.http.put(this.vehiclesEndPoint + '/' + vehicle.id, vehicle);
  }

  delete(id: number): Observable<any> {
    return this.http.delete(this.vehiclesEndPoint + '/' + id);
  }

  toQueryString(obj: any) {
    var parts = [];
    for (var property in obj) {
      var value = obj[property];
      if (value != null && value != undefined)
        parts.push(encodeURIComponent(property) + '=' + encodeURIComponent(value));
    }

    return parts.join('&');
  }

}
