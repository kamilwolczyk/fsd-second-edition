import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { ContainerComponent } from './app-display/container/container.component';
import { TableComponent } from './app-display/container/table/table.component';
import { RestaurantDatabaseService } from './restaurant-database.service';
import { SummaryComponent } from './app-display/container/summary/summary.component';
import { OrderService } from './app-display/container/order.service';
import { HelpersService } from './helpers.service';


@NgModule({
  declarations: [
    AppComponent,
    ContainerComponent,
    TableComponent,
    SummaryComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [RestaurantDatabaseService, OrderService, HelpersService],
  bootstrap: [AppComponent]
})
export class AppModule { }
