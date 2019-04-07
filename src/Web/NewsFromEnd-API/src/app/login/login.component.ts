import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material';
import { environment } from '../../environments/environment.prod';
import { ActivatedRoute, Router } from '@angular/router';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loading = false;
  submitted = false;

  constructor(public dialogRef: MatDialogRef<LoginComponent>) {
     }

  ngOnInit() {
    console.log(environment.apiUrl);
  }
 onNoClick(): void {
    this.dialogRef.close();
  }

}
