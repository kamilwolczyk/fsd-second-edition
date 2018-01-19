import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { ContainerComponent } from './layout/container/container.component';
import { RestaurantProductTableComponent } from './feature/restaurant-orders/restaurant-product-table/restaurant-product-table.component';
import { RestaurantProductComponent } from './feature/restaurant-orders/restaurant-product/restaurant-product.component';
import { ProductService } from './data-source/product.service';


@NgModule({
  declarations: [
    AppComponent,
    ContainerComponent,
    RestaurantProductTableComponent,
    RestaurantProductComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [
    ProductService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
