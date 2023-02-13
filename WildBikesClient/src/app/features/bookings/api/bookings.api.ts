import { Observable } from 'rxjs';

import { Injectable } from '@angular/core';
import { ApiService } from '@core/services';

import { BookingCreateInterface, BookingReadInterface, DocumentInterface, SignatureInterface } from '../interfaces';

@Injectable({
  providedIn: 'root'
})
export class BookingsApi {
  constructor(
    private readonly apiService: ApiService
  ) { }

  public getByUuid(uuid: string): Observable<BookingReadInterface> {
    return this.apiService.get<BookingReadInterface>(`bookings/${uuid}`);
  }

  public getAll(): Observable<BookingReadInterface[]> {
    return this.apiService.get(`bookings`);
  }

  public create(booking: BookingCreateInterface): Observable<BookingReadInterface> {
    return this.apiService.post(`bookings`, booking);
  }

  public update(uuid: string, booking: BookingCreateInterface): Observable<BookingReadInterface> {
    return this.apiService.put(`bookings/${uuid}`, booking);
  }

  public deleteByUuid(uuid: string): Observable<unknown> {
    return this.apiService.delete(`bookings/${uuid}`);
  }

  public deleteMany(uuids: string[]): Observable<unknown> {
    return this.apiService.post(`bookings/delete-many`, uuids);
  }
  
  public sign(uuid: string, signature: SignatureInterface): Observable<unknown> {
    return this.apiService.post(`bookings/${uuid}/sign`, signature);
  }
  
  public getDocument(uuid: string): Observable<DocumentInterface> {
    return this.apiService.get(`bookings/${uuid}/document`);
  }
}
