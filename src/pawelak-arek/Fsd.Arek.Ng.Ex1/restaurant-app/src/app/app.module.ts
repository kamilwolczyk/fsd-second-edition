import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { ContainerComponent } from './layout/container/container.component';
import { RestaurantProductTableComponent } from './feature/restaurant-orders/restaurant-product-table/restaurant-product-table.component';
import { RestaurantProductComponent } from './feature/restaurant-orders/restaurant-product/restaurant-product.component';
import { ProductService } from './data-source/product.service';
import { OrderService } from './models/orders/order.service';
import { RestaurantOrderTableComponent } from './feature/restaurant-orders/restaurant-order-table/restaurant-order-table.component';


@NgModule({
  declarations: [
    AppComponent,
    ContainerComponent,
    RestaurantProductTableComponent,
    RestaurantProductComponent,
    RestaurantOrderTableComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [
    ProductService,
    OrderService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
