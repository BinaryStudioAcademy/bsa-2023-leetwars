import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthorizedGuard } from '@core/guards/authorized.guard';
import { UnAuthorizedGuard } from '@core/guards/unauthorized.guard';
import { NotFoundComponent } from '@shared/components/not-found/not-found.component';

const routes: Routes = [
    {
        path: '',
        loadChildren: () => import('./modules/landing/landing.module').then((m) => m.LandingModule),
        canActivate: [UnAuthorizedGuard],
    },
    {
        path: 'main',
        loadChildren: () => import('./modules/main/main.module').then((m) => m.MainModule),
        canActivate: [AuthorizedGuard],
    },
    {
        path: 'auth',
        loadChildren: () => import('./modules/login/log-in.module').then((m) => m.LogInModule),
        canActivate: [UnAuthorizedGuard],
    },
    {
        path: 'user',
        loadChildren: () => import('./modules/user/user.module').then((m) => m.UserModule),
        canActivate: [AuthorizedGuard],
    },
    {
        path: 'challenges',
        loadChildren: () => import('./modules/challenges/challenges.module').then((m) => m.ChallengesModule),
        canActivate: [AuthorizedGuard],
    },
    {
        path: 'challenges/:id',
        loadChildren: () => import('./modules/online-editor/online-editor.module').then((m) => m.OnlineEditorModule),
        canActivate: [AuthorizedGuard],
    },
    { path: '**', component: NotFoundComponent, pathMatch: 'full' },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})
export class AppRoutingModule {}
