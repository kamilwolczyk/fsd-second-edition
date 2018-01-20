import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MainComponent } from './main/main.component';
import { ContainerComponent } from './layout/container/container.component';
import { HeaderComponent } from './layout/header/header.component';
import { FooterComponent } from './layout/footer/footer.component';
import { RestaurantProductsComponent } from './restaurant/restaurant-products/restaurant-products.component';
import { RestaurantProductsListComponent } from './restaurant/restaurant-products-list/restaurant-products-list.component';
import { ChoiceComponent } from './restaurant/choice/choice.component';
import { ChoiceService } from './restaurant/choice/choice.service';


@NgModule({
  declarations: [
    MainComponent,
    ContainerComponent,
    HeaderComponent,
    FooterComponent,
    RestaurantProductsComponent,
    RestaurantProductsListComponent,
    ChoiceComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [ChoiceService],
  bootstrap: [MainComponent]
})
export class AppModule { }
