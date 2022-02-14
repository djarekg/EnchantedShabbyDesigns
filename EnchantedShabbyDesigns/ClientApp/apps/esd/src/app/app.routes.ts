import { Routes } from '@angular/router';
import { AppGuard } from './app.guard';
import { AppLayoutComponent, AppLayoutMainComponent } from './layouts';

export const ROUTES: Routes = [
  {
    path: '',
    component: AppLayoutComponent,
    children: [
      {
        path: '',
        loadChildren: () =>
          import('./pages/signin/signin.module').then(
            (module) => module.AppSigninModule
          ),
      },
    ],
  },
  {
    path: 'main',
    component: AppLayoutMainComponent,
    canActivate: [AppGuard],
    children: [
      {
        path: 'home',
        loadChildren: () =>
          import('./pages/main/home/home.module').then(
            (module) => module.AppHomeModule
          ),
      },
    ],
  },
  {
    path: '**',
    redirectTo: '',
  },
];
