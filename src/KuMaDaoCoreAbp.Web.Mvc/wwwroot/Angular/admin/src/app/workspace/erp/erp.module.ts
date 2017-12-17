import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule } from '@angular/router';
import { HttpModule, JsonpModule, Http} from '@angular/http';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

import { LeftNavComponent } from '../component/left-nav/left-nav.component';
import { AppSideMenuComponent } from '../component/left-nav/app-side-menu/app-side-menu.component';
//import { TopMenuComponent } from '../component/top-menu/top-menu.component';
import { ErpComponent } from './erp.component';

import { erpRoutes } from './erp.routes';

import { EventBusService } from '../common/services/event-bus.service';
import {AppSideMenuService}  from "../common/services/app-side-menu.service";

@NgModule({
    imports: [
       
    
       
        FormsModule,
        ReactiveFormsModule,
        CommonModule,
        RouterModule.forChild(erpRoutes)
    ],
    exports: [],
    declarations: [
        ErpComponent,    
        
       // TopMenuComponent,
        LeftNavComponent,        
        AppSideMenuComponent,      
     
         
    ],
    providers: [AppSideMenuService] //EventBusService,
})
export class ErpModule {
    typeMenu:number=0;
    buyHandler(event:number){
        this.typeMenu =event;
    }
 }
