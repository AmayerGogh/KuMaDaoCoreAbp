(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["workspace-erp-erp-module"],{

/***/ "./src/app/workspace/component/left-nav/app-side-menu/app-side-menu.component.html":
/*!*****************************************************************************************!*\
  !*** ./src/app/workspace/component/left-nav/app-side-menu/app-side-menu.component.html ***!
  \*****************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = " <ul class=\"layout-menu\">\r\n     <li *ngFor=\"let menu of menus\">\r\n        <a href=\"javascript:void(0);\" (click)=\"toggleMenuItem($event,menu)\">\r\n            <i class=\"fa fa-fw {{menu.icon?menu.icon:'fa-bars'}}\"></i>\r\n            <span>{{menu.name}}</span>\r\n            <i class=\"fa fa-fw fa-angle-down\"></i>\r\n        </a>\r\n         <div class=\"layout-menu-tooltip\">\r\n            <div class=\"layout-menu-tooltip-arrow\"></div>\r\n            <div class=\"layout-menu-tooltip-text\">{{menu.name}}</div>\r\n        </div> \r\n        <ul class=\"{{menu.isOpen?'':'hidden'}}\">\r\n            <li *ngFor=\"let child of menu.children\">\r\n                <a href=\"javascript:void(0);\" routerLink=\"{{child.route?child.route:'/home'}}\"><i class=\"fa fa-fw {{child.icon?child.icon:'fa-bars'}}\"></i><span>{{child.name}}</span></a>\r\n                <div class=\"layout-menu-tooltip\">\r\n                    <div class=\"layout-menu-tooltip-arrow\"></div>\r\n                    <div class=\"layout-menu-tooltip-text\">{{child.name}}</div>\r\n                </div>\r\n            </li>\r\n        </ul>\r\n    </li> \r\n</ul> "

/***/ }),

/***/ "./src/app/workspace/component/left-nav/app-side-menu/app-side-menu.component.scss":
/*!*****************************************************************************************!*\
  !*** ./src/app/workspace/component/left-nav/app-side-menu/app-side-menu.component.scss ***!
  \*****************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/workspace/component/left-nav/app-side-menu/app-side-menu.component.ts":
/*!***************************************************************************************!*\
  !*** ./src/app/workspace/component/left-nav/app-side-menu/app-side-menu.component.ts ***!
  \***************************************************************************************/
/*! exports provided: AppSideMenuComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppSideMenuComponent", function() { return AppSideMenuComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _common_services_app_side_menu_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../../common/services/app-side-menu.service */ "./src/app/workspace/common/services/app-side-menu.service.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


var AppSideMenuComponent = /** @class */ (function () {
    function AppSideMenuComponent(elementRef, 
    //   private eventBusService: EventBusService, 
    thisServeice) {
        this.elementRef = elementRef;
        this.thisServeice = thisServeice;
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
        this.menus = [];
        this.isCollapse = false;
        this.NavType = 1;
        // this.menus =this.thisServeice.getMenu(this.NavType);
        // console.log(this.menus)
    }
    AppSideMenuComponent.prototype.ngOnChanges = function () {
    };
    AppSideMenuComponent.prototype.ngOnInit = function () {
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
        this.menus = this.thisServeice.getMenu(this.NavType);
    };
    AppSideMenuComponent.prototype.toggleMenuItem = function (event, menu) {
        menu.isOpen = !menu.isOpen;
        //折叠状态下只能打开一个二级菜单层
        if (this.isCollapse) {
            var tempId_1 = menu.id;
            this.menus.forEach(function (item) {
                if (item.id !== tempId_1) {
                    item.isOpen = false;
                }
            });
        }
    };
    AppSideMenuComponent.prototype.onBodyClick = function (event) {
        if (this.isCollapse && (event.clientX > 75)) {
            this.menus.forEach(function (item) {
                item.isOpen = false;
            });
        }
    };
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["HostListener"])('body:click', ['$event']),
        __metadata("design:type", Function),
        __metadata("design:paramtypes", [Object]),
        __metadata("design:returntype", void 0)
    ], AppSideMenuComponent.prototype, "onBodyClick", null);
    AppSideMenuComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-side-menu',
            template: __webpack_require__(/*! ./app-side-menu.component.html */ "./src/app/workspace/component/left-nav/app-side-menu/app-side-menu.component.html"),
            styles: [__webpack_require__(/*! ./app-side-menu.component.scss */ "./src/app/workspace/component/left-nav/app-side-menu/app-side-menu.component.scss")],
            providers: [_common_services_app_side_menu_service__WEBPACK_IMPORTED_MODULE_1__["AppSideMenuService"]]
        }),
        __metadata("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_0__["ElementRef"],
            _common_services_app_side_menu_service__WEBPACK_IMPORTED_MODULE_1__["AppSideMenuService"]])
    ], AppSideMenuComponent);
    return AppSideMenuComponent;
}());



/***/ }),

/***/ "./src/app/workspace/component/left-nav/left-nav.component.html":
/*!**********************************************************************!*\
  !*** ./src/app/workspace/component/left-nav/left-nav.component.html ***!
  \**********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"layout-menu-wrapper layout-menu-dark\">\r\n    <div class=\"nano\">\r\n        <div class=\"nano-content sidebar-scroll-content\">\r\n            <div class=\"layout-menu-container\">\r\n                <div class=\"mobile-search\">\r\n                    <i class=\"fa fa-fw fa-search topbar-search-icon\"></i>\r\n                    <input class=\"topbar-search\" placeholder=\"Type your search here\" type=\"text\">\r\n                </div>\r\n               \r\n                <app-side-menu ></app-side-menu> \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n"

/***/ }),

/***/ "./src/app/workspace/component/left-nav/left-nav.component.scss":
/*!**********************************************************************!*\
  !*** ./src/app/workspace/component/left-nav/left-nav.component.scss ***!
  \**********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/workspace/component/left-nav/left-nav.component.ts":
/*!********************************************************************!*\
  !*** ./src/app/workspace/component/left-nav/left-nav.component.ts ***!
  \********************************************************************/
/*! exports provided: LeftNavComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LeftNavComponent", function() { return LeftNavComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var LeftNavComponent = /** @class */ (function () {
    function LeftNavComponent() {
    }
    LeftNavComponent.prototype.ngOnInit = function () {
    };
    LeftNavComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'left-nav',
            template: __webpack_require__(/*! ./left-nav.component.html */ "./src/app/workspace/component/left-nav/left-nav.component.html"),
            styles: [__webpack_require__(/*! ./left-nav.component.scss */ "./src/app/workspace/component/left-nav/left-nav.component.scss")]
        }),
        __metadata("design:paramtypes", [])
    ], LeftNavComponent);
    return LeftNavComponent;
}());



/***/ }),

/***/ "./src/app/workspace/erp/erp.component.html":
/*!**************************************************!*\
  !*** ./src/app/workspace/erp/erp.component.html ***!
  \**************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\r\n <div class=\"layout-main\">\r\n     <left-nav></left-nav> \r\n    <div class=\"layout-content\">         \r\n        <router-outlet></router-outlet>\r\n     </div>   \r\n</div> \r\n\r\n"

/***/ }),

/***/ "./src/app/workspace/erp/erp.component.scss":
/*!**************************************************!*\
  !*** ./src/app/workspace/erp/erp.component.scss ***!
  \**************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "body {\n  background-color: red !important; }\n"

/***/ }),

/***/ "./src/app/workspace/erp/erp.component.ts":
/*!************************************************!*\
  !*** ./src/app/workspace/erp/erp.component.ts ***!
  \************************************************/
/*! exports provided: ErpComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ErpComponent", function() { return ErpComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var ErpComponent = /** @class */ (function () {
    function ErpComponent() {
        this.isCollapsed = false;
    }
    ErpComponent.prototype.ngOnInit = function () {
    };
    ErpComponent.prototype.toggleMenuStatus = function (isCollapse) {
        this.isCollapsed = isCollapse;
    };
    ErpComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'erp',
            template: __webpack_require__(/*! ./erp.component.html */ "./src/app/workspace/erp/erp.component.html"),
            styles: [__webpack_require__(/*! ./erp.component.scss */ "./src/app/workspace/erp/erp.component.scss")],
        }),
        __metadata("design:paramtypes", [])
    ], ErpComponent);
    return ErpComponent;
}());



/***/ }),

/***/ "./src/app/workspace/erp/erp.module.ts":
/*!*********************************************!*\
  !*** ./src/app/workspace/erp/erp.module.ts ***!
  \*********************************************/
/*! exports provided: ErpModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ErpModule", function() { return ErpModule; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _component_left_nav_left_nav_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../component/left-nav/left-nav.component */ "./src/app/workspace/component/left-nav/left-nav.component.ts");
/* harmony import */ var _component_left_nav_app_side_menu_app_side_menu_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../component/left-nav/app-side-menu/app-side-menu.component */ "./src/app/workspace/component/left-nav/app-side-menu/app-side-menu.component.ts");
/* harmony import */ var _erp_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./erp.component */ "./src/app/workspace/erp/erp.component.ts");
/* harmony import */ var _erp_routes__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./erp.routes */ "./src/app/workspace/erp/erp.routes.ts");
/* harmony import */ var _common_services_app_side_menu_service__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ../common/services/app-side-menu.service */ "./src/app/workspace/common/services/app-side-menu.service.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};






//import { TopMenuComponent } from '../component/top-menu/top-menu.component';



var ErpModule = /** @class */ (function () {
    function ErpModule() {
        this.typeMenu = 0;
    }
    ErpModule.prototype.buyHandler = function (event) {
        this.typeMenu = event;
    };
    ErpModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [
                _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormsModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_2__["ReactiveFormsModule"],
                _angular_common__WEBPACK_IMPORTED_MODULE_3__["CommonModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"].forChild(_erp_routes__WEBPACK_IMPORTED_MODULE_7__["erpRoutes"])
            ],
            exports: [],
            declarations: [
                _erp_component__WEBPACK_IMPORTED_MODULE_6__["ErpComponent"],
                // TopMenuComponent,
                _component_left_nav_left_nav_component__WEBPACK_IMPORTED_MODULE_4__["LeftNavComponent"],
                _component_left_nav_app_side_menu_app_side_menu_component__WEBPACK_IMPORTED_MODULE_5__["AppSideMenuComponent"],
            ],
            providers: [_common_services_app_side_menu_service__WEBPACK_IMPORTED_MODULE_8__["AppSideMenuService"]] //EventBusService,
        })
    ], ErpModule);
    return ErpModule;
}());



/***/ }),

/***/ "./src/app/workspace/erp/erp.routes.ts":
/*!*********************************************!*\
  !*** ./src/app/workspace/erp/erp.routes.ts ***!
  \*********************************************/
/*! exports provided: erpRoutes */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "erpRoutes", function() { return erpRoutes; });
/* harmony import */ var _erp_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./erp.component */ "./src/app/workspace/erp/erp.component.ts");

//import { WorkspaceComponent } from './workspace.component';
//import {DashboardComponent} from "../workspace/dashboard/dashboard.component"
var erpRoutes = [
    {
        path: '',
        component: _erp_component__WEBPACK_IMPORTED_MODULE_0__["ErpComponent"],
        children: [
            { path: '', redirectTo: 'org', pathMatch: 'full' },
            { path: 'dashboard', loadChildren: './dashboard/dashboard.module#DashboardModule' },
            { path: 'org', loadChildren: './org/org.module#OrgModule' },
        ]
    }
];


/***/ })

}]);
//# sourceMappingURL=workspace-erp-erp-module.js.map