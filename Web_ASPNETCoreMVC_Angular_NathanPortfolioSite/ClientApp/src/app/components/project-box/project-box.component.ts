import { AfterViewInit, Component, ViewChild, Input } from '@angular/core';
import { EventService } from 'src/app/services/eventService';

@Component({
  selector: 'app-project-box',
  templateUrl: './project-box.component.html',
  styleUrls: ['./project-box.component.css'],
})
export class ProjectBoxComponent implements AfterViewInit {
  @Input('onclick') onClick?: () => void;
  @ViewChild('container') containerRef: any;

  constructor() {}

  ngAfterViewInit(): void {
    const container: HTMLElement = this.containerRef.nativeElement;

    container.onclick = () => {
      EventService.publishEvent('fadeOut');
      setTimeout(() => (window.location.pathname = '/projects'), 1000);
    };
  }
}
