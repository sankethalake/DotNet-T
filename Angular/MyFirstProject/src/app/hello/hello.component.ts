import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-hello',
  //templateUrl: './hello.component.html',
  template: `<div>
  Enter your name<input type="text" value="{{name}}">
  <button (click)="greet()">Greet me</button>
</div>`,
  styleUrls: ['./hello.component.css']
})
export class HelloComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  name: string = "Sanket";

  greet(): void{
    alert("Hello" + this.name);
  }

}
