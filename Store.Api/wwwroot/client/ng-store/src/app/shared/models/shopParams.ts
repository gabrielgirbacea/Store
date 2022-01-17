import { Guid } from 'guid-typescript';

export class ShopParams {
  brandId: Guid | undefined = undefined;
  typeId: Guid | undefined = undefined;
  sort: string = 'name';
  pageIndex: number = 1;
  pageSize: number = 2;
}
