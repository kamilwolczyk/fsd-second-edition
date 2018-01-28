import { Injectable } from '@angular/core';
import { Player } from './player';

@Injectable()
export class PlayerService {
  players: Player[];

  constructor() {
    this.players = [
      new Player(1, 'Jan', 'III Sobieski', 7),
      new Player(2, 'Zygmunt', 'Stary', 9),
      new Player(3, 'Kazimierz', 'Wielki', 1),
      new Player(4, 'Mieszko', 'I', 4),
    ];
  }

}
