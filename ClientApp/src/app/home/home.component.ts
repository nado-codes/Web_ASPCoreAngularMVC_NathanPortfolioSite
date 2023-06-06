import { AfterViewInit, Component, ViewChild } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent implements AfterViewInit {
  @ViewChild('audio') audioRef: any;

  ngAfterViewInit(): void {
    // this.audioRef.nativeElement.play();
  }
}
