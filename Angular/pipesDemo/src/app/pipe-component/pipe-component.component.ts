import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pipe-component',
  templateUrl: './pipe-component.component.html',
  styleUrls: ['./pipe-component.component.css']
})
export class PipeComponentComponent implements OnInit {
  name: string | undefined;
  dateToday: string | undefined;
  price:number|undefined;
  constructor() { }

  ngOnInit(): void {
    this.dateToday = new Date().toDateString();
    this.name = "Angular pipes Application"
    this.price = 45000;
  }

  

}
