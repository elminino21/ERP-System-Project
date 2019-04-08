import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(public dialogRef: MatDialogRef<RegisterComponent> ) { }

  ngOnInit() {
  }
   onNoClick(): void {
    this.dialogRef.close();
  }

}
