import { Component, ViewChild, AfterViewInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
})
export class AppComponent implements AfterViewInit {
  title = 'app';
  @ViewChild('background') backgroundRef: any;
  @ViewChild('backgroundShade') backgroundShadeRef: any;

  pageBackgrounds: Record<string, string> = {
    '/': '../../assets/backgrounds/main.png',
    '/projects': '../../assets/backgrounds/projects.png',
    '/experience': '../../assets/backgrounds/skillsExperience.png',
    '/contact': '../../assets/backgrounds/contact.png',
    '/about': '../../assets/backgrounds/about.png',
  };
  prevUrl: string = '../../assets/backgrounds/main.png';
  doneFirstLoad: boolean = false;

  ngAfterViewInit(): void {
    const background: HTMLElement = this.backgroundRef.nativeElement;
    const backgroundShade: HTMLElement = this.backgroundShadeRef.nativeElement;
    const self = this;

    background.style.backgroundImage = `url(${self.prevUrl})`;

    window.addEventListener('load', function () {
      const url: string =
        self.pageBackgrounds[window.location.pathname] ??
        '../../assets/backgrounds/main.png';

      backgroundShade.style.animation = 'fadeOut 1s forwards';
      this.setTimeout(() => {
        background.style.backgroundImage = `url(${url})`;
      }, 1000);
      this.setTimeout(() => {
        backgroundShade.style.animation = 'fadeIn 1s forwards';
      }, 1000);
    });
  }
}
