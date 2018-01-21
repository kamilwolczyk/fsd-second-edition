import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MainComponent } from './main/main.component';
import { ContainerComponent } from './layout/container/container.component';
import { HeaderComponent } from './layout/header/header.component';
import { FooterComponent } from './layout/footer/footer.component';
import { MenuListComponent } from './features/lists/menu-list/menu-list.component';
import { SelectedListComponent } from './features/lists/selected-list/selected-list.component';
import { SelectedListService } from './features/services/selected-list.service';
import { ProductsMenuComponent } from './features/products-menu/products-menu.component';
import { DishesService } from './features/services/dishes.service';
import { DrinksService } from './features/services/drinks.service';


@NgModule({
  declarations: [
    MainComponent,
    ContainerComponent,
    HeaderComponent,
    FooterComponent,
    MenuListComponent,
    SelectedListComponent,
    ProductsMenuComponent,
  ],
  imports: [
    BrowserModule
  ],
  providers: [
    SelectedListService,
    DishesService,
    DrinksService
  ],
  bootstrap: [MainComponent]
})
export class AppModule { }
