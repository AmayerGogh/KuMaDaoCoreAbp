import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Subject } from 'rxjs';

import { Menu,MenuDetail} from "../models/menu"
@Injectable()
export class AppSideMenuService {
   
    
    constructor() { }

    public  getMenu(type:number){
     
        if(type==1){
            return this.menu1;
        }else if(type ==2){
            return this.menu2;
        }
      
     
    }

    public menu1:Menu[] = [       
        {
            id: 4,
            name: "控制面板",
            isOpen: false,
            icon:'fa-wrench',
            children: [
                { name: "test",icon:'fa-male',route:'org'},
                { name: "bstables",icon:'fa-bug',route:'blog' },
                { name: "ueditor",icon:'fa-bus',route:'role/roletable/page/1' },
                { name: "markdown",icon:'fa-send',route:'permission/permissiontable/page/1' },
                { name: "qiniu",icon:'fa-send',route:'permission/permissiontable/page/1' },
                { name: "Fonts",icon:'fa-send',route:'permission/permissiontable/page/1' },
                { name: "Styling Components",icon:'fa-send',route:'permission/permissiontable/page/1' },
                { name: "Custom Theme",icon:'fa-send',route:'permission/permissiontable/page/1' },
            ]
        }
    ];
    public menu2:Menu[] = [
      
        {
            id: 2,
            name: "Styles",
            isOpen: false,
            icon:'fa-home',
            children: [
                { name: "Colors",icon:'fa-male',route:'org/orgmng'},
                { name: "Icons",icon:'fa-bug',route:'user/usertable/page/1' },
                { name: "Animation",icon:'fa-bus',route:'role/roletable/page/1' },
                { name: "Acrylic",icon:'fa-send',route:'permission/permissiontable/page/1' },
                { name: "Typography",icon:'fa-send',route:'permission/permissiontable/page/1' },
                { name: "Fonts",icon:'fa-send',route:'permission/permissiontable/page/1' },
                { name: "Styling Components",icon:'fa-send',route:'permission/permissiontable/page/1' },
                { name: "Custom Theme",icon:'fa-send',route:'permission/permissiontable/page/1' },
            ]
        },
        {
            id: 3,
            name: "Components",
            isOpen: false,
            icon:'fa-magic',
            children: [
                { name: "Animate",icon:'fa-mobile',route:'post/posttable/page/1' },
                { name: "AppBarButton",icon:'fa-minus',route:'comment/commenttable/page/1' },
                { name: "AutoSuggestBox",icon:'fa-minus',route:'comment/commenttable/page/1' },
                { name: "Button",icon:'fa-minus',route:'comment/commenttable/page/1' },
                { name: "CheckBox",icon:'fa-minus',route:'comment/commenttable/page/1' },
                { name: "ColorPicker",icon:'fa-minus',route:'comment/commenttable/page/1' },
                { name: "CommandBar",icon:'fa-minus',route:'comment/commenttable/page/1' },
                { name: "ContentDialog",icon:'fa-minus',route:'comment/commenttable/page/1' },
                { name: "DatePickers",icon:'fa-minus',route:'comment/commenttable/page/1' },
                { name: "DropDownMenu",icon:'fa-minus',route:'comment/commenttable/page/1' },
                { name: "FlipView",icon:'fa-minus',route:'comment/commenttable/page/1' },
                { name: "Flyout",icon:'fa-minus',route:'comment/commenttable/page/1' },
                { name: "Button",icon:'fa-minus',route:'comment/commenttable/page/1' },

            ]
        },
        {
            id: 4,
            name: "系统监控",
            isOpen: false,
            icon:'fa-wrench',
            children: [
                { name: "系统状态",icon:'fa-line-chart',route:'sys/sysmonitor' },
                { name: "高德地图",icon:'fa-map-marker',route:'map/map' }
            ]
        }
    ];
}