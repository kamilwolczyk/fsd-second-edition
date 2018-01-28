import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PlayersListComponent } from './players-list/players-list.component';
import { PlayerCreateFormComponent } from './player-create-form/player-create-form.component';
import { PlayerSectionComponent } from './player-section/player-section.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [
    PlayersListComponent,
    PlayerCreateFormComponent,
    PlayerSectionComponent
  ],
  exports: [
    PlayerSectionComponent
  ]
})
export class PlayersModule { }
