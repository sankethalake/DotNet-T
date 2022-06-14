import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'directivesDemo';

 // ng if demo
  showmsg =false;
  readme(){
    this.showmsg=true;
    console.log('button clicked');
  }
 //ng for directive
  people:any[] = [
    {
      "name":"Douglas pace"
    },
    {
      "name":"Jay Joshi"
    },
    {
      "name":"Anant Rajpurohit"
    },
    {
      "name":"Yash Gaikwad"
    },
  ]

  // forms directive
  username: string="Forms Directive";

}
