import { Component, ViewChild, ElementRef, AfterViewInit } from '@angular/core';

@Component({
  selector: 'app-profile-picture-animated',
  templateUrl: './profile-picture-animated.component.html',
  styleUrls: ['./profile-picture-animated.component.css'],
})
export class ProfilePictureAnimatedComponent implements AfterViewInit {
  @ViewChild('profilepic', { static: true }) buttonRef!: ElementRef;

  constructor() {}

  ngAfterViewInit(): void {
    this.playAnimation();
  }

  playAnimation() {
    const profilePic = this.buttonRef?.nativeElement;

    setTimeout(() => {
      profilePic.style.animation = 'pulse 2s linear infinite';
    }, 1500);
  }
}
