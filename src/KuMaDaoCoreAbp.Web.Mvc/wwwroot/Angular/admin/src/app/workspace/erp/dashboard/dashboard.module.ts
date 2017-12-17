import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard.component';
import { dashboardRoutes } from './dashboard.routes';


@NgModule({
  imports: [
    CommonModule,  
    RouterModule.forChild(dashboardRoutes)
  ],
  declarations: [
    DashboardComponent,
  
  ],
  providers: [
    
  ]
})
export class DashboardModule { }
