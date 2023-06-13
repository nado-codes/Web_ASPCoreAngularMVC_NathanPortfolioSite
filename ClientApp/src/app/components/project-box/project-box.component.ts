import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { EventService } from 'src/app/services/eventService';

@Component({
  selector: 'app-project-box',
  templateUrl: './project-box.component.html',
  styleUrls: ['./project-box.component.css'],
})
export class ProjectBoxComponent implements AfterViewInit {
  @ViewChild('pageContainer') pageContainerRef: any;
  @ViewChild('container') containerRef: any;

  constructor() {}

  ngAfterViewInit(): void {
    const pageContainer: HTMLElement = this.pageContainerRef.nativeElement;
    const container: HTMLElement = this.containerRef.nativeElement;

    container.onclick = () => {
      pageContainer.style.animation = 'slideToLeft 1s forwards';

      EventService.publishEvent('fadeOut');
      setTimeout(() => (window.location.pathname = '/projects'), 1000);
    };
  }
}
