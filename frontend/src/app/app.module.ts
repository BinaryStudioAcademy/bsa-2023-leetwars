import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

import { SharedModule } from './shared/shared.module';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
    declarations: [AppComponent],
    providers: [],
    bootstrap: [AppComponent],
    imports: [BrowserModule, AppRoutingModule, BrowserAnimationsModule, ToastrModule.forRoot(), SharedModule],
})
export class AppModule {}
