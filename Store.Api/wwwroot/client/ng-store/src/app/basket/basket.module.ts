import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BasketComponent } from './basket.component';
import { BasketRoutingModule } from './basket-routing.module';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';

@NgModule({
  declarations: [BasketComponent],
  imports: [CommonModule, BasketRoutingModule],
})
export class BasketModule {
  baseUrl = environment.apiUrl;

  constructor(private http:HttpClient) {

  }
}
