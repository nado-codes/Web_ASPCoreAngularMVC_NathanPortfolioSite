import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { EventService } from 'src/app/services/eventService';

@Component({
  selector: 'app-menu-main',
  templateUrl: './menu-main.component.html',
  styleUrls: ['./menu-main.component.css'],
})
export class MenuMainComponent implements AfterViewInit {
  @ViewChild('btnProjects') btnProjectsRef: any;
  @ViewChild('container') containerRef: any;

  constructor() {}

  ngAfterViewInit(): void {
    const btnProjects: HTMLButtonElement = this.btnProjectsRef.nativeElement;
    const container: HTMLElement = this.containerRef.nativeElement;

    btnProjects.onclick = () => {
      container.style.animation = 'slideToLeft 1s forwards';

      EventService.publishEvent('fadeOut');
      setTimeout(() => (window.location.pathname = '/projects'), 1000);
    };
  }
}
