import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MainComponent } from './main/main.component';
import { ContainerComponent } from './layout/container/container.component';
import { HeaderComponent } from './layout/header/header.component';
import { FooterComponent } from './layout/footer/footer.component';
import { DishesComponent } from './features/menu/dishes/dishes.component';
import { DrinksComponent } from './features/menu/drinks/drinks.component';
import { MenuListComponent } from './features/menu/menu-list/menu-list.component';


@NgModule({
  declarations: [
    MainComponent,
    ContainerComponent,
    HeaderComponent,
    FooterComponent,
    DishesComponent,
    DrinksComponent,
    MenuListComponent,
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [MainComponent]
})
export class AppModule { }
