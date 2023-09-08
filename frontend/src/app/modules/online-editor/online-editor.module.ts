import { LayoutModule } from '@angular/cdk/layout';
import { NgModule } from '@angular/core';
import { NgbModule, NgbNavModule } from '@ng-bootstrap/ng-bootstrap';
import { SharedModule } from '@shared/shared.module';
import { AngularSplitModule } from 'angular-split';
import { MarkdownModule } from 'ngx-markdown';
import { MonacoEditorModule, NgxMonacoEditorConfig } from 'ngx-monaco-editor-v2';

import { OnlineEditorPageComponent } from './online-editor-page/online-editor-page.component';
import { OnlineEditorRoutingModule } from './online-editor-routing.module';

const monacoConfig: NgxMonacoEditorConfig = {
    baseUrl: '/assets',
    defaultOptions: { scrollBeyondLastLine: false },
    onMonacoLoad: () => {
        // eslint-disable-next-line @typescript-eslint/no-explicit-any
        (<any>window).monaco.editor.defineTheme('custom-theme', {
            base: 'vs-dark',
            inherit: true,
            rules: [],
            colors: {
                'editor.background': '#222327',
            },
        });
    },
};

@NgModule({
    declarations: [OnlineEditorPageComponent],
    imports: [
        SharedModule,
        OnlineEditorRoutingModule,
        NgbNavModule,
        NgbModule,
        LayoutModule,
        MarkdownModule.forRoot(),
        AngularSplitModule,
        MonacoEditorModule.forRoot(monacoConfig),
    ],
})
export class OnlineEditorModule {}
