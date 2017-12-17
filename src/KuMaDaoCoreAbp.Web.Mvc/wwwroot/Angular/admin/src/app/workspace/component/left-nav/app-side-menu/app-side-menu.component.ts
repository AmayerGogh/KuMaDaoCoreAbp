import { Component, OnInit, ElementRef, HostListener, Input } from '@angular/core';
import { EventBusService } from '../../../common/services/event-bus.service';
import { CommonModule } from '@angular/common';

import { NgForOf } from '@angular/common';
import { Menu } from '../../../common/models/menu';
import {AppSideMenuService} from "../../../common/services/app-side-menu.service"
@Component({
    selector: 'app-side-menu',
    templateUrl: './app-side-menu.component.html',
    styleUrls: ['./app-side-menu.component.scss'],
    providers:[ AppSideMenuService]
})
export class AppSideMenuComponent implements OnInit {
    // public menus = [
    //     {
    //         id: "1",
    //         name: "首页",
    //         isOpen: false,
    //         icon:'fa-home',         
    //     },
    //     {
    //         id: "2",
    //         name: "Styles",
    //         isOpen: false,
    //         icon:'fa-home',
    //         children: [
    //             { name: "Colors",icon:'fa-male',route:'org/orgmng'},
    //             { name: "Icons",icon:'fa-bug',route:'user/usertable/page/1' },
    //             { name: "Animation",icon:'fa-bus',route:'role/roletable/page/1' },
    //             { name: "Acrylic",icon:'fa-send',route:'permission/permissiontable/page/1' },
    //             { name: "Typography",icon:'fa-send',route:'permission/permissiontable/page/1' },
    //             { name: "Fonts",icon:'fa-send',route:'permission/permissiontable/page/1' },
    //             { name: "Styling Components",icon:'fa-send',route:'permission/permissiontable/page/1' },
    //             { name: "Custom Theme",icon:'fa-send',route:'permission/permissiontable/page/1' },
    //         ]
    //     },
    //     {
    //         id: "3",
    //         name: "Components",
    //         isOpen: false,
    //         icon:'fa-magic',
    //         children: [
    //             { name: "Animate",icon:'fa-mobile',route:'post/posttable/page/1' },
    //             { name: "AppBarButton",icon:'fa-minus',route:'comment/commenttable/page/1' },
    //             { name: "AutoSuggestBox",icon:'fa-minus',route:'comment/commenttable/page/1' },
    //             { name: "Button",icon:'fa-minus',route:'comment/commenttable/page/1' },
    //             { name: "CheckBox",icon:'fa-minus',route:'comment/commenttable/page/1' },
    //             { name: "ColorPicker",icon:'fa-minus',route:'comment/commenttable/page/1' },
    //             { name: "CommandBar",icon:'fa-minus',route:'comment/commenttable/page/1' },
    //             { name: "ContentDialog",icon:'fa-minus',route:'comment/commenttable/page/1' },
    //             { name: "DatePickers",icon:'fa-minus',route:'comment/commenttable/page/1' },
    //             { name: "DropDownMenu",icon:'fa-minus',route:'comment/commenttable/page/1' },
    //             { name: "FlipView",icon:'fa-minus',route:'comment/commenttable/page/1' },
    //             { name: "Flyout",icon:'fa-minus',route:'comment/commenttable/page/1' },
    //             { name: "Button",icon:'fa-minus',route:'comment/commenttable/page/1' },

    //         ]
    //     },
    //     {
    //         id: "4",
    //         name: "系统监控",
    //         isOpen: false,
    //         icon:'fa-wrench',
    //         children: [
    //             { name: "系统状态",icon:'fa-line-chart',route:'sys/sysmonitor' },
    //             { name: "高德地图",icon:'fa-map-marker',route:'map/map' }
    //         ]
    //     }
    // ];

    public menus:Menu[] =[];
    public isCollapse: boolean = false;
    private NavType:number =1;
    constructor(
        private elementRef: ElementRef, 
     //   private eventBusService: EventBusService, 
        private thisServeice :AppSideMenuService) { 
           // this.menus =this.thisServeice.getMenu(this.NavType);
           // console.log(this.menus)
         }
    ngOnChanges(){
     
    }    
    ngOnInit() {
        // this.eventBusService.topToggleBtn.subscribe(value => {
        //     this.isCollapse = value;
        //     this.menus.forEach(item => {
        //         item.isOpen = false;
        //     })
           
        // });
        // this.eventBusService.leftNav.subscribe(value=>{
        //      if(this.NavType!=value){
        //         this.NavType =value;            
        //         this.menus =this.thisServeice.getMenu(this.NavType);
        //      }
            
        // })
    
       //仅在第一次时候
       this.menus =this.thisServeice.getMenu(this.NavType);      
    }
    public toggleMenuItem(event, menu): void {
        menu.isOpen = !menu.isOpen;
        //折叠状态下只能打开一个二级菜单层
        if (this.isCollapse) {
            let tempId = menu.id;
            this.menus.forEach(item => {
                if (item.id !== tempId) {
                    item.isOpen = false;
                }
            });
        }
    }

    @HostListener('body:click', ['$event'])
    public onBodyClick(event): void {
        if (this.isCollapse && (event.clientX > 75)) {
            this.menus.forEach(item => {
                item.isOpen = false;
            });
        }
    }
}