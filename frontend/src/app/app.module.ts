import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { SharedModule } from '@shared/shared.module';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { MonacoEditorModule } from 'ngx-monaco-editor-v2';

@NgModule({
    declarations: [AppComponent],
    imports: [BrowserModule, SharedModule, AppRoutingModule, MonacoEditorModule.forRoot()],
    providers: [],
    bootstrap: [AppComponent],
})
export class AppModule {}
