
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Student } from '../../models/std';
import { Students } from '../../models/stu_m';
import { ServiceService } from '../../service.service';
import { map } from 'rxjs/operators'

@Component({
  selector: 'app-aboutstudent',
  templateUrl: './aboutstudent.component.html',
  styleUrls: ['./aboutstudent.component.scss']
})
export class AboutstudentComponent implements OnInit {
  name!: string;
  department!: string;
  name1!: string;
  department1!: string;
  data: any;
  data2: any;
  postdata: any;
  form!: NgForm;
  x: any;
  constructor(private ServiceServie: ServiceService) { }

  ngOnInit(): void {
    //debugger;
    this.getdata();
    this.getdatafromdb1();
    
  }
  students: Students[] = [
    {
      name: 'Raj',
      department: 'CS'
    },
    {
      name: 'Ram',
      department: 'CS'
    },
    //{
    //  name: 'Riya',
    //  department: 'CS'
    //}
  ];

  submit(form: NgForm) {
    debugger;
    console.log(form.value);
    //this.ServiceServie.postData(this.form.value).subscribe((postdata) => {
    //  this.postdata = postdata;
    //  console.log("postdata");
    //});
  }
  addRow() {
    //this.getdata2();
    this.students.push({
      name: this.name,
      department: this.department

    });
  }

  editstudent(index: any) {

  }
  deletestudent(index: any) {
    this.students.splice(index, 1);
    //this.ServiceServie.deleteData()
  }

  getdata() {
    this.ServiceServie.getData().subscribe((data:any) => {
      this.data = data;
      console.log(data);
    });
  }
  getdatafromdb1() {
    debugger;
    this.ServiceServie.getDatafromDb().subscribe((data2: any) => {
      this.data2 = data2;
      //console.log(data2.name);
      //console.log(data2.department);
      console.log(data2);
    

      console.log(JSON.stringify(data2));
      this.x = JSON.stringify(this.data2)
      //this.name1 = this.data2.name;
      //this.department1 = this.data2.department;
      //console.log(this.name1);
      //console.log(this.department1);



    })
  }

  

  //getdata2() {
  //  this.ServiceServie.getData().subscribe((data2: any) => {
  //    this.data2 = data2;
  //    console.log(data2);
  //  });
  //}

}
