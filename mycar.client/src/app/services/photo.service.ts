import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class PhotoService {
  constructor(private http: HttpClient) { }

  upload(photo: any, vehicleId: number): Observable<any> {
    var formData = new FormData();
    formData.append('file', photo);
    return this.http.post(`https://localhost:7106/api/vehicles/${vehicleId}/photos`, formData);
  }

  getPhotos(vehicleId: number): Observable<any> {
    return this.http.get(`https://localhost:7106/api/vehicles/${vehicleId}/photos`);
  }
}
