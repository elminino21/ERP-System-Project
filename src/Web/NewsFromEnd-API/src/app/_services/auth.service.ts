import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { User } from '../models/user.model';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private currentUserSubject: BehaviorSubject<User>;
  public currentUser: Observable<User>;

  constructor(private http: HttpClient) {
    this.currentUserSubject = new BehaviorSubject<User>(JSON.parse(localStorage.getItem('currentUser')));
    this.currentUser = this.currentUserSubject.asObservable();
   }

   public get currentUserValue(): User {
     return this.currentUserSubject.value;
   }

   /**
    * return an obserable
    * with user info if exist
    */
   login(username: string, password: string) {
     return this.http.post<any>('${config.apiUrl}/users/authenticate', { username, password })
     .pipe(map( user => {
       if ( user && user.token ) {
          localStorage.setItem('currentUser', JSON.stringify(user));
       }

     }
     ));

   }

   logout() {
    localStorage.getItem('currentUser');

    this.currentUserSubject.next(null); // set the next value to null

   }
}
