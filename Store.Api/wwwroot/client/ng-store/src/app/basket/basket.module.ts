import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BasketComponent } from './basket.component';
import { BasketRoutingModule } from './basket-routing.module';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  declarations: [BasketComponent],
  imports: [CommonModule, BasketRoutingModule, SharedModule],
})
export class BasketModule {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}
}
