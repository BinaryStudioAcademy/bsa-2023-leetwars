import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from '@core/guards/auth.guard';
import { NotFoundComponent } from '@shared/components/not-found/not-found.component';

const routes: Routes = [
    {
        path: '',
        loadChildren: () => import('./modules/landing/landing.module').then((m) => m.LandingModule),
    },
    {
        path: 'main',
        loadChildren: () => import('./modules/main/main.module').then((m) => m.MainModule),
        canActivate: [AuthGuard],
    },
    {
        path: 'auth',
        loadChildren: () => import('./modules/login/log-in.module').then((m) => m.LogInModule),
    },
    {
        path: 'user',
        loadChildren: () => import('./modules/user/user.module').then((m) => m.UserModule),
    },
    {
        path: 'challenges',
        loadChildren: () => import('./modules/challenges/challenges.module').then((m) => m.ChallengesModule),
    },
    {
        path: 'problems/:id',
        loadChildren: () => import('./modules/online-editor/online-editor.module').then((m) => m.OnlineEditorModule),
    },
    { path: '**', component: NotFoundComponent, pathMatch: 'full' },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})
export class AppRoutingModule {}
