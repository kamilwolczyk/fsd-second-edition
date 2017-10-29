import { Product } from 'app/products';

export interface IProductService {
  getAllProducts(): Product[];
}
