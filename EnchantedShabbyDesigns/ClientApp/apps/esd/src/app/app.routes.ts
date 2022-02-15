import { Routes } from '@angular/router';
import { AppLayoutComponent, AppLayoutMainComponent } from './layouts';
import { AppGuard } from './shared/guards';

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
        path: 'login',
        loadChildren: () =>
          import('./pages/signin/signin.module').then(
            (module) => module.AppSigninModule
          ),
      },
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
