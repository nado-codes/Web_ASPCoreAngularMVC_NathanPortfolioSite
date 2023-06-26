import { Component, OnInit, Input, ViewChild } from '@angular/core';
import { Utils } from 'src/utils/utils';

interface Bubble {
  anchorOrigin: number | string;
  anchorTarget: number | string;
  xOrigin: number | string;
  yOrigin: number | string;
  xTarget: number | string;
}

@Component({
  selector: 'app-bubble',
  templateUrl: './bubble.component.html',
  styleUrls: ['./bubble.component.css'],
})
export class BubbleComponent implements OnInit {
  @Input() position?: Bubble;
  @ViewChild('bubbleEl') bubbleElementRef: any;
  bubble: Bubble;
  id: string = '';

  /*

    @keyframes circleLeft {
      from {
        right: calc(0%);
      }
      to {
        right: calc(100%);
      }
    }

    @keyframes circleRight {
      from {
        left: calc(0%);
      }
      to {
        left: calc(100%);
      }
    } */

  constructor() {
    const bubbleObj = {
      top: {
        anchorOrigin: '25%',
        anchorTarget: '-50%',
        xOrigin: '0%',
        yOrigin: '0%',
        xTarget: '150px',
      },
      topLeft: {
        anchorOrigin: '25%',
        anchorTarget: '-50%',
        xOrigin: '0%',
        yOrigin: '0%',
        xTarget: '150px',
      },
      bottom: {
        anchorOrigin: '25%',
        anchorTarget: '100%',
        xOrigin: '0%',
        yOrigin: '25%',
        xTarget: '-150px',
      },
      left: {
        anchorOrigin: '0%',
        anchorTarget: '100%',
        xOrigin: 0,
        yOrigin: 0,
        xTarget: 0,
      },
      right: {
        anchorOrigin: '0%',
        anchorTarget: '100%',
        xOrigin: 0,
        yOrigin: 0,
        xTarget: 0,
      },
    };

    this.bubble = this.position ?? {
      anchorOrigin: '25%',
      anchorTarget: '-50%',
      xOrigin: '0%',
      yOrigin: '0%',
      xTarget: '150px',
    };
  }

  ngOnInit(): void {
    const styleSheet = document.createElement('style');
    document.head.appendChild(styleSheet);
    this.id = Utils.GenerateUniqueId();
    const animationName = `bubbleMove-${this.id}`;

    if (styleSheet.sheet !== null) {
      styleSheet.sheet.insertRule(`
        @keyframes ${animationName} {
          from {
            ${this.position}: calc(${this.bubble.anchorOrigin});
            transform: translate(0%, 0%);
          }
          to {
            ${this.position}: calc(${this.bubble.anchorTarget});
            transform: translate(${this.bubble.xOrigin}, ${this.bubble.yOrigin}) translateX(${this.bubble.xTarget});
          }
        }
    `);
    }
  }

  ngAfterViewInit(): void {
    this.bubbleElementRef.nativeElement.style.animation = `bubbleMove-${this.id} 2s forwards, bubblePulse 2s forwards infinite`;
  }
}
