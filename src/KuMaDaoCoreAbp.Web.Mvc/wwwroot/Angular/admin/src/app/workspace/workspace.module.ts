import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule } from '@angular/router';
import { HttpModule, JsonpModule, Http} from '@angular/http';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';


import { LeftNavComponent } from './component/left-nav/left-nav.component';
import { AppSideMenuComponent } from './component/left-nav/app-side-menu/app-side-menu.component';

import { TopMenuComponent } from './component/top-menu/top-menu.component';
import { WorkspaceComponent } from './workspace.component';
//import {ErpComponent} from './erp/erp.component'
import { workspaceRoutes } from './workspace.routes';

import { EventBusService } from './common/services/event-bus.service';
import {AppSideMenuService}  from "./common/services/app-side-menu.service";

@NgModule({
    imports: [
        FormsModule,
        ReactiveFormsModule,
        CommonModule,
        RouterModule.forChild(workspaceRoutes)
    ],
    exports: [],
    declarations: [
        TopMenuComponent,
      //  LeftNavComponent,        
       // AppSideMenuComponent,      
        WorkspaceComponent,                   
    ],
    providers: [AppSideMenuService,EventBusService] //
})
export class WorkspaceModule {
    typeMenu:number=0;
    buyHandler(event:number){
        this.typeMenu =event;
    }
 }
