import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { ProfilePictureAnimatedComponent } from '../profile-picture-animated/profile-picture-animated.component';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent implements AfterViewInit {
  @ViewChild('widescreen_top') widescreenTopRef: any;
  @ViewChild('widescreen_bottom') widescreenBottomRef: any;

  @ViewChild('sc1_btn_start') sc1BtnStartRef: any;
  @ViewChild('sc1_container') sc1ContainerRef: any;

  @ViewChild('sc2_container') sc2ContainerRef: any;
  @ViewChild('sc2_audio') sc2AudioRef: any;
  @ViewChild('sc2a_profilepic') sc2aProfilePicRef: any;
  widescreenTop: any;
  widescreenBottom: any;

  ngAfterViewInit(): void {
    this.widescreenTop = this.widescreenTopRef.nativeElement;
    this.widescreenBottom = this.widescreenBottomRef.nativeElement;

    const sc1BtnStart: HTMLButtonElement = this.sc1BtnStartRef.nativeElement;
    const sc1Container: HTMLDivElement = this.sc1ContainerRef.nativeElement;

    const sc2Container: HTMLDivElement = this.sc2ContainerRef.nativeElement;
    const sc2a_profilePic: HTMLElement = this.sc2aProfilePicRef.buttonRef;

    sc1BtnStart.onclick = () => {
      this.playScene2();
      sc1Container.style.display = 'none';
      sc2Container.style.display = 'inline';
      this.widescreenTop.style.display = 'inline';
      this.widescreenBottom.style.display = 'inline';
    };
  }

  playScene2() {
    const audio: HTMLAudioElement = this.sc2AudioRef.nativeElement;
    audio.play();

    setTimeout(() => {}, 3000);
  }
}
