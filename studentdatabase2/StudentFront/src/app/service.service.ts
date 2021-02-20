import { Inject, Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';  
import { Observable } from 'rxjs';
import { Student_model } from './models/student_model';
import { Students } from './models/stu_m';
@Injectable({
  providedIn: 'root'
})
export class ServiceService {

  constructor(private http: HttpClient) { }
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }
 
  getData() {
    //debugger;
    return this.http.get('/api/Student/GetStudentDetails');
    
  }
  getDatafromDb() {
    debugger;
    return this.http.get('https://localhost:44308/api/Student/GetStudentsfromdb');
  }
  //getData2() {
  //  debugger;
  //  return this.http.get('/api/Student/GetStudent');

  //}
  //GetStudents(): Observable<Students> {
  //  return this.http.get < Students>(this.)
  //}
  postData(formData: any) {
    debugger;
    return this.http.post('https://localhost:44308/api/Student/PostStudentstodb',formData);
    //return this.http.post('/api/Student/PostStudent', formData);
  }
  putData(id: string, formData: any) {
    return this.http.put('/api/Student/' + id, formData);
  }
  deleteData(id: any) {
    //return this.http.delete('/api/Student/' + id);
    debugger;
    return this.http.post('https://localhost:44308/api/Student/DeleteDtudentfromdb', id)
  }

}
