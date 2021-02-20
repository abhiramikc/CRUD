import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormControl } from '@angular/forms';
import { Student } from '../../models/studentform.model';
import { Router } from '@angular/router';
import { ServiceService } from '../../service.service';
@Component({
  selector: 'app-aboutteacher',
  templateUrl: './aboutteacher.component.html',
  styleUrls: ['./aboutteacher.component.scss']
})
export class AboutteacherComponent implements OnInit {

  aboutstudent: FormGroup;
  studentmodel: Student;
  submitted: boolean = false;
  postdata: any;
  x: any;
  data2: any;
  details: any;
  public href: string = "";
  url: any;
  constructor(private formBuilder: FormBuilder, private serviceservice: ServiceService, private router: Router) {
    this.studentmodel = new Student();
    this.aboutstudent = this.formBuilder.group({
      name: ["",Validators.required],
      department:["",Validators.required]
    });
    this.getdatafromdb1();
  }

  ngOnInit() {
    this.href = this.router.url;
    console.log(this.router.url);
  }
  Submit() {
    debugger;
    this.submitted = true;
    if (this.aboutstudent.invalid) {
      console.log(this.studentmodel);
      return;
    }
    else {
      debugger;
      console.log(this.studentmodel);
      this.x=this.serviceservice.postData(this.studentmodel).subscribe((postdata) => {
        this.postdata = postdata;
        console.log(this.postdata);
        if (this.x) {
          alert("saved ");
        }
      });

     
    }
  }

  getdatafromdb1() {
    debugger;
    this.serviceservice.getDatafromDb().subscribe((data2: any) => {
      this.data2 = data2;
      console.log(data2);
      console.log(data2[0].name);
    });
  }

  EditStudent(details: any) {
    console.log(details);
  }
      
}
