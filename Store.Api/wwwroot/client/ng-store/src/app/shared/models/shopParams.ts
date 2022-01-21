export class ShopParams {
  brandId: string | undefined = undefined;
  typeId: string | undefined = undefined;
  sort: string = 'name';
  pageIndex: number = 1;
  pageSize: number = 2;
  search: string | undefined = undefined;
}
