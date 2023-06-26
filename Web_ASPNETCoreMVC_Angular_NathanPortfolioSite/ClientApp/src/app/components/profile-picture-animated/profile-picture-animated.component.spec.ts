import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProfilePictureAnimatedComponent } from './profile-picture-animated.component';

describe('ProfilePictureAnimatedComponent', () => {
  let component: ProfilePictureAnimatedComponent;
  let fixture: ComponentFixture<ProfilePictureAnimatedComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProfilePictureAnimatedComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProfilePictureAnimatedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
