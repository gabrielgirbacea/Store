import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IPagination } from '../shared/models/pagination';
import { IBrand } from '../shared/models/productBrand';
import { IType } from '../shared/models/productType';
import { map } from 'rxjs/operators';
import { ShopParams } from '../shared/models/shopParams';

@Injectable({
  providedIn: 'root',
})
export class ShopService {
  baseUrl: string = 'https://localhost:5001/api/';

  constructor(private http: HttpClient) {}

  getProducts(shopParams: ShopParams): Observable<IPagination> {
    let params = new HttpParams();

    params = shopParams.brandId
      ? params.append('brandId', shopParams.brandId.toString())
      : params;
    params = shopParams.typeId
      ? params.append('typeId', shopParams.typeId.toString())
      : params;
    params = shopParams.search
      ? params.append('search', shopParams.search)
      : params;
    params = params.append('sort', shopParams.sort);
    params = params.append('pageIndex', shopParams.pageIndex);
    params = params.append('pageSize', shopParams.pageSize);

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
