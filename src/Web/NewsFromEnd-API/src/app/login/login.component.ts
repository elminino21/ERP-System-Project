import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material';
import { environment } from '../../environments/environment.prod';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor( public dialogRef: MatDialogRef<LoginComponent> ) { }
  user: any = {};

  ngOnInit() {
    console.log(environment.apiUrl);
  }
 onNoClick(): void {
    this.dialogRef.close();
  }
}
