import { Component } from '@angular/core';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { LoginComponent } from '../login/login.component';
import { MatDialog } from '@angular/material';
import { RegisterComponent } from '../register/register.component';

@Component({
  selector: 'app-main-nav',
  templateUrl: './main-nav.component.html',
  styleUrls: ['./main-nav.component.css']
})
export class MainNavComponent {

  isHandset$: Observable<boolean> = this.breakpointObserver.observe(Breakpoints.Handset)
    .pipe(
      map(result => result.matches)
    );

  constructor(private breakpointObserver: BreakpointObserver,
     public signinDialog: MatDialog, public registerDiaglo: MatDialog) {}

  signinDiagloOpen(): void {
    const dialogRef = this.signinDialog.open(LoginComponent, {
      /* s
      data: {name: this.name, animal: this.animal}
      */
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }
    registerDiagloOpen(): void {
      const registerRef = this.registerDiaglo.open(RegisterComponent, {
    });
    registerRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
    }

}