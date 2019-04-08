import { Injectable } from '@angular/core';
import { Router, ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot } from '@angular/router';
import { AuthService } from './auth.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuardService implements CanActivate {

  constructor( private router: Router, private auth: AuthService ) { }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {

    const currentUser = this.auth.currentUserValue;
    if ( currentUser ) {
      return true;
    }
       this.router.navigate(['/'], { queryParams: { returnUrl: state.url }});
    return false;

  }


}
