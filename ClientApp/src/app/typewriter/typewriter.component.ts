import {
  Component,
  OnInit,
  ElementRef,
  ViewChild,
  AfterViewInit,
} from '@angular/core';

@Component({
  selector: 'app-typewriter',
  templateUrl: './typewriter.component.html',
  styleUrls: ['./typewriter.component.css'],
})
export class TypewriterComponent implements AfterViewInit {
  @ViewChild('container', { static: true }) containerRef!: ElementRef;

  constructor() {}

  ngAfterViewInit(): void {
    const container = this.containerRef.nativeElement;

    setTimeout(() => {
      container.style.animation = 'blink 0.25s forwards infinite';
    }, 1000);
  }
}
