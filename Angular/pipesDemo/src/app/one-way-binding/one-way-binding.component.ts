import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-one-way-binding',
  templateUrl: './one-way-binding.component.html',
  styleUrls: ['./one-way-binding.component.css']
})
export class OneWayBindingComponent implements OnInit {
  fontsize : number = 70;

  //attribute binding
  imageHeight: number = 150;
  imageWidth: number = 150;
  imagePath: string ="assets/IMG_7865 (1).jpg";
  constructor() { }

  ngOnInit(): void {
  }

  SayHello(){
    console.log("Hello I am exploring");
  }

}
