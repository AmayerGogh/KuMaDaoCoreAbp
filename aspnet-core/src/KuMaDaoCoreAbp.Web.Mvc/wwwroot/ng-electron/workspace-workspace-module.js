(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["workspace-workspace-module"],{

/***/ "./src/app/workspace/common/services/event-bus.service.ts":
/*!****************************************************************!*\
  !*** ./src/app/workspace/common/services/event-bus.service.ts ***!
  \****************************************************************/
/*! exports provided: EventBusService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "EventBusService", function() { return EventBusService; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm5/index.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


/**
 * 事件总线，组件之间可以通过这个服务进行通讯
 */
var EventBusService = /** @class */ (function () {
    function EventBusService() {
        this.topToggleBtn = new rxjs__WEBPACK_IMPORTED_MODULE_1__["Subject"]();
        this.leftNav = new rxjs__WEBPACK_IMPORTED_MODULE_1__["Subject"]();
    }
    EventBusService = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Injectable"])(),
        __metadata("design:paramtypes", [])
    ], EventBusService);
    return EventBusService;
}());



/***/ }),

/***/ "./src/app/workspace/component/top-menu/top-menu.component.html":
/*!**********************************************************************!*\
  !*** ./src/app/workspace/component/top-menu/top-menu.component.html ***!
  \**********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"topbar topbar-dark\">\r\n    <a class=\"topbar-logo\" routerlink=\"/\">\r\n        Ng-Fluent\r\n    </a>\r\n \r\n\r\n\r\n    <a href=\"javascript:void(0);\" class=\"menu-button\" routerLink=\"erp\">\r\n        <i class=\"fa fa-bars\">erp</i>\r\n    </a>\r\n    <a href=\"javascript:void(0);\" class=\"menu-button\" routerLink=\"fluent\">\r\n        <i class=\"fa fa-bars\">fluent</i>\r\n    </a>\r\n    <a href=\"javascript:void(0);\" class=\"user-display\" (click)=\"showTopMenu=!showTopMenu\">\r\n        <span class=\"username\">大漠穷秋</span>\r\n        <img src=\"assets/imgs/img.jpg\" style=\"border: 0px;\">\r\n        <i class=\"fa fa-angle-down\"></i>\r\n    </a>\r\n    <ul class=\"fadeInDown topbar-menu {{showTopMenu?'topbar-menu-visible':''}}\">\r\n        <li>\r\n            <a href=\"http://damoqiongqiu.github.io\" target=\"_blank\">\r\n                <i class=\"topbar-icon fa fa-fw fa-user\"></i>\r\n                <span class=\"topbar-item-name\">用户资料</span>\r\n            </a>\r\n        </li>\r\n        <li>\r\n            <a href=\"javascript:void(0);\" (click)=\"showTopMenu=false;\">\r\n                <i class=\"topbar-icon fa fa-fw fa-cog\"></i>\r\n                <span class=\"topbar-item-name\">个人设置</span>\r\n            </a>\r\n        </li>\r\n        <li>\r\n            <a href=\"javascript:void(0);\" (click)=\"showTopMenu=false;\">\r\n                <i class=\"topbar-icon material-icons animated swing fa fa-fw fa-envelope-o\"></i>\r\n                <span class=\"topbar-item-name\">消息</span>\r\n                <span class=\"topbar-badge animated rubberBand\">4</span>\r\n            </a>\r\n        </li>\r\n        <li>\r\n            <a href=\"javascript:void(0);\" (click)=\"showTopMenu=false;\" routerLink=\"/login\">\r\n                <i class=\"topbar-icon fa fa-fw  fa-power-off \"></i>\r\n                <span class=\"topbar-item-name\">退出</span>\r\n                <span class=\"topbar-badge animated rubberBand\">2</span>\r\n            </a>\r\n        </li>\r\n    </ul>\r\n</div>"

/***/ }),

/***/ "./src/app/workspace/component/top-menu/top-menu.component.scss":
/*!**********************************************************************!*\
  !*** ./src/app/workspace/component/top-menu/top-menu.component.scss ***!
  \**********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/workspace/component/top-menu/top-menu.component.ts":
/*!********************************************************************!*\
  !*** ./src/app/workspace/component/top-menu/top-menu.component.ts ***!
  \********************************************************************/
/*! exports provided: TopMenuComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TopMenuComponent", function() { return TopMenuComponent; });
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

var TopMenuComponent = /** @class */ (function () {
    //_menuService:MenuService;
    //
    // @Output()
    // public  buy:EventEmitter<number> =new  EventEmitter();
    function TopMenuComponent() {
        this.toggleBtnStatus = false;
        this.showTopMenu = false;
    }
    TopMenuComponent.prototype.ngOnInit = function () {
    };
    TopMenuComponent.prototype.onTogglerClick = function (event) {
        // this.toggleBtnStatus=!this.toggleBtnStatus;
        // this.eventBusService.topToggleBtn.next(this.toggleBtnStatus);
        // this.eventBusService.leftNav.next(1);
    };
    TopMenuComponent.prototype.onTogglerClick2 = function (event) {
        // this.toggleBtnStatus=!this.toggleBtnStatus;
        // this.eventBusService.topToggleBtn.next(this.toggleBtnStatus);
        // this.eventBusService.leftNav.next(2);
    };
    TopMenuComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'top-menu',
            template: __webpack_require__(/*! ./top-menu.component.html */ "./src/app/workspace/component/top-menu/top-menu.component.html"),
            styles: [__webpack_require__(/*! ./top-menu.component.scss */ "./src/app/workspace/component/top-menu/top-menu.component.scss")]
        }),
        __metadata("design:paramtypes", [])
    ], TopMenuComponent);
    return TopMenuComponent;
}());



/***/ }),

/***/ "./src/app/workspace/workspace.component.html":
/*!****************************************************!*\
  !*** ./src/app/workspace/workspace.component.html ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"layout-wrapper {{isCollapsed?'layout-menu-slim':'layout-menu-static'}}\">\r\n    <top-menu></top-menu>\r\n    <div class=\"layout-main\">\r\n         <!-- <left-nav></left-nav> \r\n        <div class=\"layout-content\"> -->\r\n            <router-outlet></router-outlet>\r\n        <!-- </div> -->\r\n    </div>\r\n</div>\r\n\r\n"

/***/ }),

/***/ "./src/app/workspace/workspace.component.scss":
/*!****************************************************!*\
  !*** ./src/app/workspace/workspace.component.scss ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/workspace/workspace.component.ts":
/*!**************************************************!*\
  !*** ./src/app/workspace/workspace.component.ts ***!
  \**************************************************/
/*! exports provided: WorkspaceComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "WorkspaceComponent", function() { return WorkspaceComponent; });
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

var WorkspaceComponent = /** @class */ (function () {
    function WorkspaceComponent() {
        this.isCollapsed = false;
    }
    WorkspaceComponent.prototype.ngOnInit = function () {
    };
    WorkspaceComponent.prototype.toggleMenuStatus = function (isCollapse) {
        this.isCollapsed = isCollapse;
    };
    WorkspaceComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'workspace',
            template: __webpack_require__(/*! ./workspace.component.html */ "./src/app/workspace/workspace.component.html"),
            styles: [__webpack_require__(/*! ./workspace.component.scss */ "./src/app/workspace/workspace.component.scss")],
        }),
        __metadata("design:paramtypes", [])
    ], WorkspaceComponent);
    return WorkspaceComponent;
}());



/***/ }),

/***/ "./src/app/workspace/workspace.module.ts":
/*!***********************************************!*\
  !*** ./src/app/workspace/workspace.module.ts ***!
  \***********************************************/
/*! exports provided: WorkspaceModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "WorkspaceModule", function() { return WorkspaceModule; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _component_top_menu_top_menu_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./component/top-menu/top-menu.component */ "./src/app/workspace/component/top-menu/top-menu.component.ts");
/* harmony import */ var _workspace_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./workspace.component */ "./src/app/workspace/workspace.component.ts");
/* harmony import */ var _workspace_routes__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./workspace.routes */ "./src/app/workspace/workspace.routes.ts");
/* harmony import */ var _common_services_event_bus_service__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./common/services/event-bus.service */ "./src/app/workspace/common/services/event-bus.service.ts");
/* harmony import */ var _common_services_app_side_menu_service__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./common/services/app-side-menu.service */ "./src/app/workspace/common/services/app-side-menu.service.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};






//import {ErpComponent} from './erp/erp.component'



var WorkspaceModule = /** @class */ (function () {
    function WorkspaceModule() {
        this.typeMenu = 0;
    }
    WorkspaceModule.prototype.buyHandler = function (event) {
        this.typeMenu = event;
    };
    WorkspaceModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [
                _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormsModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_2__["ReactiveFormsModule"],
                _angular_common__WEBPACK_IMPORTED_MODULE_3__["CommonModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"].forChild(_workspace_routes__WEBPACK_IMPORTED_MODULE_6__["workspaceRoutes"])
            ],
            exports: [],
            declarations: [
                _component_top_menu_top_menu_component__WEBPACK_IMPORTED_MODULE_4__["TopMenuComponent"],
                //  LeftNavComponent,        
                // AppSideMenuComponent,      
                _workspace_component__WEBPACK_IMPORTED_MODULE_5__["WorkspaceComponent"],
            ],
            providers: [_common_services_app_side_menu_service__WEBPACK_IMPORTED_MODULE_8__["AppSideMenuService"], _common_services_event_bus_service__WEBPACK_IMPORTED_MODULE_7__["EventBusService"]] //
        })
    ], WorkspaceModule);
    return WorkspaceModule;
}());



/***/ }),

/***/ "./src/app/workspace/workspace.routes.ts":
/*!***********************************************!*\
  !*** ./src/app/workspace/workspace.routes.ts ***!
  \***********************************************/
/*! exports provided: workspaceRoutes */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "workspaceRoutes", function() { return workspaceRoutes; });
/* harmony import */ var _workspace_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./workspace.component */ "./src/app/workspace/workspace.component.ts");

var workspaceRoutes = [
    {
        path: '',
        component: _workspace_component__WEBPACK_IMPORTED_MODULE_0__["WorkspaceComponent"],
        children: [
            { path: '', redirectTo: 'erp', pathMatch: 'full' },
            { path: 'erp', loadChildren: "../workspace/erp/erp.module#ErpModule" },
            { path: 'fluent', loadChildren: "../workspace/fluent/fluent.module#FluentModule" },
        ]
    }
];


/***/ })

}]);
//# sourceMappingURL=workspace-workspace-module.js.map