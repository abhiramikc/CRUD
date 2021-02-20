import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StudentsComponent } from './students/students.component';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';
import { ListStudentsComponent } from './list-students/list-students.component';
import { HomeComponent } from './home/home.component';
import { HeaderComponent } from './header/header.component';
import { GetstudentListComponent } from './getstudent-list/getstudent-list.component';
import { FooterComponent } from './footer/footer.component';
import { CreateStudentComponent } from './create-student/create-student.component';
import { ContactComponent } from './contact/contact.component';
import { AboutComponent } from './about/about.component';
import { AboutstudentComponent } from './about/aboutstudent/aboutstudent.component';
import { AboutteacherComponent } from './about/aboutteacher/aboutteacher.component';
import { FormsModule } from '@angular/forms';
import { ServiceService } from './service.service';
import { HttpClientModule } from '@angular/common/http';
@NgModule({
  declarations: [
    AppComponent,
    StudentsComponent,
    PagenotfoundComponent,
    ListStudentsComponent,
    HomeComponent,
    HeaderComponent,
    GetstudentListComponent,
    FooterComponent,
    CreateStudentComponent,
    ContactComponent,
    AboutComponent,
    AboutstudentComponent,
    AboutteacherComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
