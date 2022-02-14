import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../models';

@Injectable({ providedIn: 'root' })
export class AppUserService {
  constructor(private readonly http: HttpClient) {}

  add = (user: User) => this.http.post<number>('users', user);

  delete = (id: number) => this.http.delete(`users/${id}`);

  get = (id: number) => this.http.get<User>(`users/${id}`);

  inactivate = (id: number) => this.http.patch(`users/${id}/inactivate`, {});

  list = () => this.http.get<User[]>('users');

  update = (user: User) => this.http.put(`users/${user.id}`, user);
}
