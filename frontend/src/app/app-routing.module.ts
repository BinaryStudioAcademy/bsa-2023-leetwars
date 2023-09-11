import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthorizedGuard } from '@core/guards/authorized.guard';
import { HideHeaderGuard } from '@core/guards/hide-header.guard';
import { UnAuthorizedGuard } from '@core/guards/unauthorized.guard';
import { NotFoundComponent } from '@shared/components/not-found/not-found.component';

const routes: Routes = [
    {
        path: '',
        loadChildren: () => import('./modules/main/main.module').then((m) => m.MainModule),
        canMatch: [AuthorizedGuard],
    },
    {
        path: '',
        loadChildren: () => import('./modules/landing/landing.module').then((m) => m.LandingModule),
        canActivate: [HideHeaderGuard],
    },
    {
        path: 'auth',
        loadChildren: () => import('./modules/login/log-in.module').then((m) => m.LogInModule),
        canActivate: [UnAuthorizedGuard, HideHeaderGuard],
    },
    {
        path: 'user',
        loadChildren: () => import('./modules/user/user.module').then((m) => m.UserModule),
        canActivate: [AuthorizedGuard],
    },
    {
        path: 'leader',
        loadChildren: () => import('./modules/leader/leader.module').then((m) => m.LeaderModule),
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
    { path: '**', component: NotFoundComponent, pathMatch: 'full', canActivate: [HideHeaderGuard] },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})
export class AppRoutingModule {}
