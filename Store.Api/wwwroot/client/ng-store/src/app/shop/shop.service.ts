import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Guid } from 'guid-typescript';
import { Observable } from 'rxjs';
import { IPagination } from '../shared/models/pagination';
import { IBrand } from '../shared/models/productBrand';
import { IType } from '../shared/models/productType';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class ShopService {
  baseUrl: string = 'https://localhost:5001/api/';

  constructor(private http: HttpClient) {}

  getProducts(
    brandId?: Guid,
    typeId?: Guid,
    sort?: string
  ): Observable<IPagination> {
    let params = new HttpParams();

    params = brandId ? params.append('brandId', brandId.toString()) : params;
    params = typeId ? params.append('typeId', typeId.toString()) : params;
    params = sort ? params.append('sort', sort) : params;

    return this.http
      .get<IPagination>(this.baseUrl + 'products', {
        observe: 'response',
        params: params,
      })
      .pipe(map((response) => response.body!));
  }

  getBrands(): Observable<IBrand[]> {
    return this.http.get<IBrand[]>(this.baseUrl + 'productbrands');
  }

  getTypes(): Observable<IType[]> {
    return this.http.get<IType[]>(this.baseUrl + 'producttypes');
  }
}
