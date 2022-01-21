import { Guid } from 'guid-typescript';
import { IBasketItem } from './basketItem';

export interface IBasket {
  id: string;
  items: IBasketItem[];
}
