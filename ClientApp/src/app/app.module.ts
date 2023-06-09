import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { FetchDataComponent } from './views/fetch-data/fetch-data.component';
import { ProfilePictureAnimatedComponent } from './components/profile-picture-animated/profile-picture-animated.component';
import { TypewriterComponent } from './components/typewriter/typewriter.component';
import { IntroComponent } from './views/intro/intro.component';
import { BubbleComponent } from './components/bubble/bubble.component';
import { MenuMainComponent } from './views/menu-main/menu-main.component';
import { MenuProjectsComponent } from './views/menu-projects/menu-projects.component';
import { NotFoundComponent } from './views/not-found/not-found.component';
import { ProjectBoxComponent } from './components/project-box/project-box.component';

const routes: Routes = [
  { path: '', component: MenuMainComponent, pathMatch: 'full' },
  { path: 'projects', component: MenuProjectsComponent, pathMatch: 'full' },
  { path: 'fetch-data', component: FetchDataComponent },
  { path: '**', pathMatch: 'full', component: NotFoundComponent },
];

@NgModule({
  declarations: [
    AppComponent,
    FetchDataComponent,
    ProfilePictureAnimatedComponent,
    TypewriterComponent,
    IntroComponent,
    BubbleComponent,
    MenuMainComponent,
    MenuProjectsComponent,
    NotFoundComponent,
    ProjectBoxComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(routes),
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
