import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  { path: '', redirectTo: 'app', pathMatch: 'full' },
  {
    path: 'app', loadChildren: 'app/app.module#AppModule'
  },
  {
    path: 'account',
    loadChildren: 'account/account.module#AccountModule', // Lazy load account module
    data: { preload: true },
  },
  // { path: '', redirectTo: 'account', pathMatch: 'full' },
  // { path: 'app', loadChildren: "app/app.module#AppModule" },
  // {
  //   path: 'account',
  //   loadChildren: 'account/account.module#AccountModule', // Lazy load account module
  //   data: { preload: true },
  // },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  providers: [],
})
export class RootRoutingModule { }
