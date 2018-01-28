import { Component, OnInit } from '@angular/core';
import { PlayerService } from '../../domain/players/player.service';
import { Player } from '../../domain/players/player';

@Component({
  selector: 'fsd-players-list',
  templateUrl: './players-list.component.html',
  styleUrls: ['./players-list.component.css']
})
export class PlayersListComponent implements OnInit {
  players: Player[];

  constructor(private playerService: PlayerService) { }

  ngOnInit() {
    this.players = this.playerService.players;
  }

}
