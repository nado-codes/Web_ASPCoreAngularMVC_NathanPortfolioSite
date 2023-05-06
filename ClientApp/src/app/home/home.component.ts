import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  constructor() {
    this.playAnimation();
  } 

  playAnimation () {
    const profilePic = document.getElementById("profile-pic");

    if(profilePic !== undefined)
      profilePic?.style.display = "none";
  }
}
