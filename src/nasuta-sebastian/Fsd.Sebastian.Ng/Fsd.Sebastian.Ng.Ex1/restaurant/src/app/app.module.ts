import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { ContainerComponent } from './layout/container/container.component';
import { HeaderComponent } from './layout/header/header.component';
import { FooterComponent } from './layout/footer/footer.component';
import { MainComponent } from './main/main.component';


@NgModule({
  declarations: [
    ContainerComponent,
    HeaderComponent,
    FooterComponent,
    MainComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [MainComponent]
})
export class AppModule { }
