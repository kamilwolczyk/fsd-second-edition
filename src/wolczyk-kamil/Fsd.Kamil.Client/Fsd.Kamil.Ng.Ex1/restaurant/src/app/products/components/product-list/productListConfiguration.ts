import { IProductService } from '../../services/productService';

export class ProductListConfiguration {
  constructor(public service: IProductService) { }
}
