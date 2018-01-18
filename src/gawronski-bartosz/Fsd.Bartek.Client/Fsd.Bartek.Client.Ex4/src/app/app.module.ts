import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ContainerComponent } from './layout/container/container.component';
import { TitleComponent } from './layout/title/title.component';
import { MealService } from './features/table/table-meal/meal.service';
import { DrinkService } from './features/table/table-drink/drink.service';
import { TableOrderComponent } from './features/table-order/table-order.component';
import { OrderService } from './features/table-order/order.service';
import { TableComponent } from './features/table/table.component';
import { ProductsComponent } from './features/products/products.component';

@NgModule({
  declarations: [
    AppComponent,
    ContainerComponent,
    TitleComponent,
    TableOrderComponent,
    TableComponent,
    ProductsComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [MealService, DrinkService, OrderService],
  bootstrap: [AppComponent]
})
export class AppModule { }
