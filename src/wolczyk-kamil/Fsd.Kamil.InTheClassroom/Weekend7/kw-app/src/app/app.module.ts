import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MainComponent } from './main/main.component';
import { HeaderComponent } from './layout/header/header.component';
import { ContainerComponent } from './layout/container/container.component';
import { FooterComponent } from './layout/footer/footer.component';
import { ClockPanelComponent } from './common/clock/clock-panel/clock-panel.component';
import { ClockSeparatorComponent } from './common/clock/clock-separator/clock-separator.component';
import { CodeSchoolMembersComponent } from './features/code-school/code-school-members/code-school-members.component';
import { CodeSchoolMembersListComponent } from './features/code-school/code-school-members-list/code-school-members-list.component';
import { LoggerComponent } from './common/logger/logger.component';
import { LoggerService } from './common/logger/logger.service';

@NgModule({
  declarations: [
    MainComponent,
    HeaderComponent,
    ContainerComponent,
    FooterComponent,
    ClockPanelComponent,
    ClockSeparatorComponent,
    CodeSchoolMembersComponent,
    CodeSchoolMembersListComponent,
    LoggerComponent,
  ],
  imports: [
    BrowserModule
  ],
  providers: [
    LoggerService
  ],
  bootstrap: [MainComponent]
})
export class AppModule { }
