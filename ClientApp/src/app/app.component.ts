import { Component, ViewChild, AfterViewInit } from '@angular/core';
import { EventService } from './services/eventService';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
})
export class AppComponent implements AfterViewInit {
  title = 'app';
  @ViewChild('background') backgroundRef: any;
  @ViewChild('backgroundShade') backgroundShadeRef: any;

  static instance: AppComponent;

  pageBackgrounds: Record<string, string> = {
    '/': '../../assets/backgrounds/main.png',
    '/projects': '../../assets/backgrounds/projects.png',
    '/experience': '../../assets/backgrounds/skillsExperience.png',
    '/contact': '../../assets/backgrounds/contact.png',
    '/about': '../../assets/backgrounds/about.png',
  };

  ngAfterViewInit(): void {
    const background: HTMLElement = this.backgroundRef.nativeElement;
    const backgroundShade: HTMLElement = this.backgroundShadeRef.nativeElement;
    AppComponent.instance = this;

    EventService.listenEvent('fadeOut', this.fadeOut);

    background.style.backgroundImage = `url('../../assets/backgrounds/main.png')`;
    //background.style.backgroundImage = `url(${localStorage.prevUrl})`;
    backgroundShade.style.opacity = '0.5';

    window.addEventListener('load', this.loadBackground);
  }

  fadeOut(): void {
    const backgroundShade: HTMLElement =
      AppComponent.instance.backgroundShadeRef.nativeElement;

    backgroundShade.style.animation = 'fadeOut 1s forwards';
  }

  loadBackground(): void {
    const background: HTMLElement =
      AppComponent.instance.backgroundRef.nativeElement;
    const backgroundShade: HTMLElement =
      AppComponent.instance.backgroundShadeRef.nativeElement;
    const backgroundUrl: string =
      AppComponent.instance.pageBackgrounds[window.location.pathname] ??
      '../../assets/backgrounds/main.png';

    const isRefresh = backgroundUrl === localStorage.prevUrl;

    if (isRefresh) {
      console.log('detected refresh, skip animation');
      //return;
    }

    localStorage.prevUrl = backgroundUrl;

    console.log('url=', backgroundUrl);
    console.log('prevUrl=', localStorage.prevUrl);

    background.style.backgroundImage = `url(${backgroundUrl})`;
    backgroundShade.style.animation = 'fadeIn 1s forwards';

    setTimeout(() => {
      //backgroundShade.style.animation = 'fadeIn 1s forwards';
    }, 1000);
  }
}
