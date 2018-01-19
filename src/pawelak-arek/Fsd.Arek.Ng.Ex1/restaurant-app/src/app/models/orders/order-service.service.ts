import { Injectable } from '@angular/core';
import { Order } from './order';

@Injectable()
export class OrderServiceService {

  orderList: Array<Order>;

  constructor() { }

}
