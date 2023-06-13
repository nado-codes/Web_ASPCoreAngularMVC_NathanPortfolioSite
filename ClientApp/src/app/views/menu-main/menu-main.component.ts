import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { EventService } from 'src/app/services/eventService';

@Component({
  selector: 'app-menu-main',
  templateUrl: './menu-main.component.html',
  styleUrls: ['./menu-main.component.css'],
})
export class MenuMainComponent implements AfterViewInit {
  @ViewChild('btnProjects') btnProjectsRef: any;
  @ViewChild('pageContainer') pageContainerRef: any;

  constructor() {}

  ngAfterViewInit(): void {
    const btnProjects: HTMLButtonElement = this.btnProjectsRef.nativeElement;
    const pageContainer: HTMLElement = this.pageContainerRef.nativeElement;

    btnProjects.onclick = () => {
      pageContainer.style.animation = 'slideToLeft 1s forwards';

      EventService.publishEvent('fadeOut');
      setTimeout(() => (window.location.pathname = '/projects'), 1000);
    };
  }
}
