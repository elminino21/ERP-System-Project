import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpEvent, HttpHandler, HttpRequest } from '@angular/common/http';
import { Observable } from 'rxjs';
import { AuthService } from '../_services/auth.service';

@Injectable({
  providedIn: 'root'
})
export class JwtInterceptorService implements HttpInterceptor {

  constructor(private authService: AuthService ) { }

  intercept(req:  HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {

     const currentUser = this.authService.currentUserValue;
    if ( currentUser && currentUser.token) {
        req = req.clone({
          setHeaders: {
            Authorization: 'Bearer ${currentUser.token}'
          }
        });
    }
    return next.handle(req);
  }
}
