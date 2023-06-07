import { AfterViewInit, Component, ViewChild } from '@angular/core';

@Component({
  selector: 'app-menu-main',
  templateUrl: './menu-main.component.html',
  styleUrls: ['./menu-main.component.css'],
})
export class MenuMainComponent implements AfterViewInit {
  @ViewChild('btnProjects') btnProjectsRef: any;

  constructor() {}

  ngAfterViewInit(): void {
    const btnProjects: HTMLButtonElement = this.btnProjectsRef.nativeElement;

    btnProjects.onclick = () => {
      window.location.pathname = '/projects';
    };
  }
}
