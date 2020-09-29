import { Injectable, inject, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { JusticeLeagueMember } from '../interfaces/justice-league-member';
import { JusticeLeagueComponent } from '../justice-league/justice-league.component';

@Injectable({
  providedIn: 'root'
})
export class JusticeLeagueService {

  constructor(private httpClient: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  public async getMembers(): Promise<JusticeLeagueMember[]> {
    return this.httpClient.get<JusticeLeagueMember[]>(`${this.baseUrl}justiceleaguemember`).toPromise();
  }
                                                    //(`${this.baseUrl}controllername`)
  public async addMember(member: JusticeLeagueMember): Promise<JusticeLeagueMember> {
    return this.httpClient.post<JusticeLeagueMember>(`${this.baseUrl}justiceleaguemember`, member).toPromise();
  }
}
