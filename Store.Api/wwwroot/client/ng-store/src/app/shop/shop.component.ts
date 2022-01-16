import { Component, OnInit } from '@angular/core';
import { Guid } from 'guid-typescript';
import { IProduct } from '../shared/models/product';
import { IBrand } from '../shared/models/productBrand';
import { IType } from '../shared/models/productType';
import { ShopService } from './shop.service';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.scss'],
})
export class ShopComponent implements OnInit {
  products: IProduct[] = [];
  brands: IBrand[] = [];
  types: IType[] = [];
  selectedBrandId: Guid | undefined = undefined;
  selectedTypeId: Guid | undefined = undefined;
  selectedSort: string = 'name';
  sortOptions = [
    { name: 'Alphabetical', value: 'name' },
    { name: 'Price: Low to High', value: 'priceAsc' },
    { name: 'Price: High to Low', value: 'priceDesc' },
  ];

  constructor(private shopService: ShopService) {}

  ngOnInit(): void {
    this.getProducts();
    this.getBrands();
    this.getTypes();
  }

  getProducts(): void {
    this.shopService
      .getProducts(this.selectedBrandId, this.selectedTypeId, this.selectedSort)
      .subscribe(
        (response) => (this.products = response.data),
        (error) => console.log(error)
      );
  }

  getBrands(): void {
    this.shopService.getBrands().subscribe(
      (response) => {
        this.brands = [{ id: undefined, name: 'All' }, ...response];
      },
      (error) => console.log(error)
    );
  }

  getTypes(): void {
    this.shopService.getTypes().subscribe(
      (response) => {
        this.types = [{ id: undefined, name: 'All' }, ...response];
      },
      (error) => console.log(error)
    );
  }

  onBrandSelected(brandId?: Guid) {
    this.selectedBrandId = brandId;
    this.getProducts();
  }

  onTypeSelected(typeId?: Guid) {
    this.selectedTypeId = typeId;
    this.getProducts();
  }

  onSortSelected(sort: string) {
    this.selectedSort = sort;
    this.getProducts();
  }
}
