import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AppRouteGuard } from '@shared/auth/auth-route-guard';

import { AppComponent } from '@app/app.component';


export const AppRoutes: Routes = [
  {
    path: '',
    component: AppComponent,
    //canActivate: [AppRouteGuard],
    //canActivateChild: [AppRouteGuard],
    children: [
      {
        path: 'default', loadChildren: "../app/default/default.module#DefaultModule"
      },
      {
        path: 'blog', loadChildren: "../app/blog/blog.module#BlogModule"
      },
      {
        path: '**',
        redirectTo: 'default',
      },
    ],
  },
];

