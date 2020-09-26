import { Component, OnInit } from '@angular/core';
import { JusticeLeagueService } from '../services/justice-league.service';
import { JusticeLeagueMember } from '../interfaces/justice-league-member';

@Component({
  selector: 'app-justice-league',
  templateUrl: './justice-league.component.html',
  styleUrls: ['./justice-league.component.css']
})
export class JusticeLeagueComponent implements OnInit {

  public justiceLeagueMember: JusticeLeagueMember[];

  public newMember: JusticeLeagueMember =
  {
    id: undefined,
    name: '',
    alias: '',
    age: 0,
    memberSince: null,
    isActiveMember: true,
  };

  constructor(private justiceService: JusticeLeagueService) { }

  async ngOnInit() {
    this.justiceLeagueMember = await this.justiceService.getMembers();
  }

  public async addMember()
  {
    const newMember = await this.justiceService.addMember(this.newMember);
    this.justiceLeagueMember.push(newMember);
  }
}
