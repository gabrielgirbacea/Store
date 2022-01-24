import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { BasketService } from 'src/app/basket/basket.service';
import { IBasketTotals } from '../../models/basketTotals';

@Component({
  selector: 'app-order-totals',
  templateUrl: './order-totals.component.html',
  styleUrls: ['./order-totals.component.scss'],
})
export class OrderTotalsComponent implements OnInit {
  basketTotal$: Observable<IBasketTotals | undefined>;

  constructor(private basketService: BasketService) {
    this.basketTotal$ = basketService.basketTotal$;
  }

  ngOnInit(): void {}
}
