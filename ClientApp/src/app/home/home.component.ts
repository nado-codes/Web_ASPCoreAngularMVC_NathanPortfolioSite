import { AfterViewInit, Component, ViewChild } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent implements AfterViewInit {
  @ViewChild('audio') audioRef: any;
  @ViewChild('videoPlayer') videoPlayerRef: any;
  @ViewChild('decSeek') decSeekBtnRef: any;
  @ViewChild('incSeek') incSeekBtnRef: any;

  ngAfterViewInit(): void {
    this.audioRef.nativeElement.play();

    const decSeekBtn: HTMLButtonElement = this.decSeekBtnRef.nativeElement;
    const incSeekBtn: HTMLButtonElement = this.incSeekBtnRef.nativeElement;

    decSeekBtn.onmousedown = () => this.seekByMilliseconds(-2000);
    incSeekBtn.onmousedown = () => this.seekByMilliseconds(2000);
  }

  seekByMilliseconds(milliseconds: number): void {
    const video: HTMLVideoElement = this.videoPlayerRef.nativeElement;
    const seconds = milliseconds / 1000; // Convert milliseconds to seconds
    video.currentTime += seconds; // Seek by the desired time interval in seconds
  }
}
