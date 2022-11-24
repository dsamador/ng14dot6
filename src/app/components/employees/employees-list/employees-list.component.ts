import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/models/employee.model';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.css']
})
export class EmployeesListComponent implements OnInit {

  employees: Employee[] = [
    {
      id: 1,
      name: 'Juan',
      email:'j@j.com',
      phone: 3333,
      salary: 5000,
      department: 'IT'
    },
    {
      id: 2,
      name: 'Juana',
      email:'ja@ja.com',
      phone: 3233,
      salary: 5200,
      department: 'TI'
    },
    {
      id: 1,
      name: 'JuanDa',
      email:'jd@jd.com',
      phone: 3353,
      salary: 5090,
      department: 'IT'
    },
  ];
  constructor() { }

  ngOnInit() {
    this.employees.push();
  }

}
