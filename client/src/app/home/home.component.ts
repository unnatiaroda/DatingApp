import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent  implements OnInit {
  registerMode = false;
  users: any;

  constructor() { }

  ngOnInit(): void { }

  registerToggle() {
    this.registerMode = !this.registerMode
  }

  cancelRegisterMode(event: boolean) {  //event is what is being emitted from the child component
    this.registerMode = event;
  }

}
