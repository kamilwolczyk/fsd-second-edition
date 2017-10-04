import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { MainComponent } from './main/main.component';
import { HeaderComponent } from './layout/header/header.component';
import { FooterComponent } from './layout/footer/footer.component';
import { DishService, DrinkService } from './products';
import { ProductListComponent } from './products/components/product-list/product-list.component';
import { WaiterPanelComponent } from './waiter-panel/waiter-panel.component';
import { ProductBasketComponent } from './products/components/product-basket/product-basket.component';
import { GridButtonComponent } from './shared/grid-button/grid-button.component';

@NgModule({
  declarations: [
    MainComponent,
    HeaderComponent,
    FooterComponent,
    ProductListComponent,
    WaiterPanelComponent,
    ProductBasketComponent,
    GridButtonComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [
    DishService,
    DrinkService
  ],
  bootstrap: [MainComponent]
})
export class AppModule { }
