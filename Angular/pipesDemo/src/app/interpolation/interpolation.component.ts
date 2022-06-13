import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-interpolation',
  templateUrl: './interpolation.component.html',
  styleUrls: ['./interpolation.component.css']
})
export class InterpolationComponent implements OnInit {
  subtitle = "demo";
  user = {userid : 1 , username: 'name'}
  constructor() { }

  ngOnInit(): void {
    this.subtitle = "Title";
  }

}
