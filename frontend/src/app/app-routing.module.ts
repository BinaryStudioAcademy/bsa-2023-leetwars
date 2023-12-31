import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthorizedGuard } from '@core/guards/authorized.guard';
import { HeaderGuard } from '@core/guards/header.guard';
import { UnAuthorizedGuard } from '@core/guards/unauthorized.guard';
import { NotFoundComponent } from '@shared/components/not-found/not-found.component';

const routes: Routes = [
    {
        path: '',
        loadChildren: () => import('./modules/main/main.module').then((m) => m.MainModule),
        canMatch: [AuthorizedGuard],
        canActivate: [HeaderGuard],
    },
    {
        path: '',
        loadChildren: () => import('./modules/landing/landing.module').then((m) => m.LandingModule),
    },
    {
        path: 'auth',
        loadChildren: () => import('./modules/login/log-in.module').then((m) => m.LogInModule),
        canActivate: [UnAuthorizedGuard],
    },
    {
        path: 'user',
        loadChildren: () => import('./modules/user/user.module').then((m) => m.UserModule),
        canActivate: [AuthorizedGuard, HeaderGuard],
    },
    {
        path: 'leader',
        loadChildren: () => import('./modules/leader/leader.module').then((m) => m.LeaderModule),
        canActivate: [AuthorizedGuard, HeaderGuard],
    },
    {
        path: 'challenges',
        loadChildren: () => import('./modules/challenges/challenges.module').then((m) => m.ChallengesModule),
        canActivate: [AuthorizedGuard, HeaderGuard],
    },
    { path: '**', component: NotFoundComponent, pathMatch: 'full' },
];

@NgModule({
    imports: [RouterModule.forRoot(routes, { scrollPositionRestoration: 'enabled' })],
    exports: [RouterModule],
})
export class AppRoutingModule {}
