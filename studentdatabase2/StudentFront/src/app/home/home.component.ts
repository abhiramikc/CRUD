import { Component, OnInit } from '@angular/core';
import { ServiceService } from '../service.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  data2: any;
  id: any;
  data: any;
  x: any;
  constructor(private serviceservice: ServiceService) {
    this.getdatafromdb1();
  }

  ngOnInit(): void {
  }
  getdatafromdb1() {
    //debugger;
    this.serviceservice.getDatafromDb().subscribe((data2: any) => {
      this.data2 = data2;
      console.log(data2);
      console.log(data2[0].name);
    });
  }
  deleteData(id: any) {
    console.log(id);
    debugger;
    this.x=this.serviceservice.deleteData(id).subscribe((data: any) => {
      this.data = data;
      console.log(data);
      if (this.x) {
        alert("Deleted!!")
      }
    })
  }
}
