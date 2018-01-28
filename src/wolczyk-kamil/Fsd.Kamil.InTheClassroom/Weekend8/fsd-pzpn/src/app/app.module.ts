import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { MainComponent } from './main/main.component';
import { LayoutModule } from './layout/layout.module';
import { PlayersModule } from './players/players.module';

@NgModule({
  declarations: [
    MainComponent
  ],
  imports: [
    BrowserModule,
    LayoutModule,
    PlayersModule
  ],
  providers: [],
  bootstrap: [MainComponent]
})
export class AppModule { }
