import { AfterViewInit, Component, ViewChild } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent implements AfterViewInit {
  @ViewChild('audio') audioRef: any;
  @ViewChild('videoPlayer') videoPlayerRef: any;
  @ViewChild('seektext') seekTextRef: any;
  @ViewChild('btnseek') seekBtnRef: any;

  seekTarget?: number;
  seekActive: boolean = false;

  ngAfterViewInit(): void {
    this.audioRef.nativeElement.play();

    const seekText: HTMLInputElement = this.seekTextRef.nativeElement;
    const seekBtn: HTMLButtonElement = this.seekBtnRef.nativeElement;

    const video: HTMLVideoElement = this.videoPlayerRef.nativeElement;
    // this.smoothSeek(video, 3, 1000); // Smoothly seek to the 30-second mark over 1 second

    seekBtn.onclick = () => {
      const video: HTMLVideoElement = this.videoPlayerRef.nativeElement;
      const seconds = parseFloat(seekText.value);

      video.playbackRate = seconds;
    };
  }

  smoothSeek(
    video: HTMLVideoElement,
    targetTime: number,
    duration: number
  ): void {
    const currentTime = video.currentTime;
    const timeDiff = targetTime - currentTime;
    const fps = 60; // Number of frames per second
    const frameDuration = duration / fps; // Duration of each frame
    const startTime = performance.now();

    function step(timestamp: number) {
      const elapsed = timestamp - startTime;
      const progress = Math.min(elapsed / duration, 1);
      const time = currentTime + timeDiff * progress;
      video.currentTime = time;

      if (progress < 1) {
        requestAnimationFrame(step);
      }
    }

    requestAnimationFrame(step);
  }
}
