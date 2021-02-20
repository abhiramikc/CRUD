import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { AboutstudentComponent } from './about/aboutstudent/aboutstudent.component';
import { AboutteacherComponent } from './about/aboutteacher/aboutteacher.component';
import { GetstudentListComponent } from './getstudent-list/getstudent-list.component';
import { HomeComponent } from './home/home.component';
import { ListStudentsComponent } from './list-students/list-students.component';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';
import { StudentsComponent } from './students/students.component';
const routes: Routes = [

  { path: 'students', component: StudentsComponent },
  { path: 'allstudents', component: ListStudentsComponent },
  { path: 'getlist', component: GetstudentListComponent },
  {
    path: 'about', children: [
      {
        path: '',
        component: AboutComponent
      },
      {
        path: 'aboutstudent', component: AboutstudentComponent
      },
      {
        path: 'aboutteacher', component: AboutteacherComponent
      }
    ]
  },
  {
    //path: 'home', loadChildren: './home/home.module#HomeModule'
    path: 'home', component: HomeComponent
  },
  { path: '**', component: PagenotfoundComponent }
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
