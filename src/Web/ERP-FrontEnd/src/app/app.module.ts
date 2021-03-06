import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { DragDropModule } from '@angular/cdk/drag-drop';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { ErrorComponent } from './error/error.component';
import { RegisterComponent } from './register/register.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { LoginComponent } from './login/login.component';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { AboutComponent } from './about/about.component';
import { MainNavComponent } from './main-nav/main-nav.component';
import { LayoutModule } from '@angular/cdk/layout';
import { MatToolbarModule, MatButtonModule,
  MatSidenavModule, MatIconModule, MatListModule, MatNativeDateModule, MatCardModule,
   MatDividerModule, MatMenuModule, MatBadgeModule, MatTooltipModule  } from '@angular/material';
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import {MatFormFieldModule} from '@angular/material/form-field';
import { MatInputModule } from '@angular/material';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatDialogModule} from '@angular/material/dialog';
import { UserMessageComponent } from './user-message/user-message.component';
import { GenericModalComponent } from './generic-modal/generic-modal.component';
@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ErrorComponent,
    RegisterComponent,
    DashboardComponent,
    LoginComponent,
    AboutComponent,
    MainNavComponent,
    UserMessageComponent,
    GenericModalComponent
  ],
  imports: [
    MatDatepickerModule,
    MatTooltipModule,
    MatBadgeModule,
    MatCardModule,
    MatMenuModule,
    MatDividerModule,
    BrowserModule,
    MatNativeDateModule,
    AppRoutingModule,
    MatDialogModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule,
    BrowserAnimationsModule,
    FormsModule,
    DragDropModule,
    LayoutModule,
    MatToolbarModule,
AngularFontAwesomeModule,
    MatButtonModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,
  ],
  entryComponents: [
    LoginComponent, RegisterComponent, UserMessageComponent, HomeComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
