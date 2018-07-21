(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["workspace-fluent-fluent-module"],{

/***/ "./src/app/workspace/fluent/fluent.component.html":
/*!********************************************************!*\
  !*** ./src/app/workspace/fluent/fluent.component.html ***!
  \********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\r\n <div class=\"layout-main\">\r\n     <!-- <left-nav></left-nav> \r\n    <div class=\"layout-content\">         \r\n        <router-outlet></router-outlet>\r\n     </div>    -->\r\n     <h1>fluent</h1>\r\n</div> \r\n\r\n"

/***/ }),

/***/ "./src/app/workspace/fluent/fluent.component.scss":
/*!********************************************************!*\
  !*** ./src/app/workspace/fluent/fluent.component.scss ***!
  \********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "body {\n  background-color: red !important; }\n"

/***/ }),

/***/ "./src/app/workspace/fluent/fluent.component.ts":
/*!******************************************************!*\
  !*** ./src/app/workspace/fluent/fluent.component.ts ***!
  \******************************************************/
/*! exports provided: FluentComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "FluentComponent", function() { return FluentComponent; });
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

var FluentComponent = /** @class */ (function () {
    function FluentComponent() {
        this.isCollapsed = false;
    }
    FluentComponent.prototype.ngOnInit = function () {
    };
    FluentComponent.prototype.toggleMenuStatus = function (isCollapse) {
        this.isCollapsed = isCollapse;
    };
    FluentComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'fluent',
            template: __webpack_require__(/*! ./fluent.component.html */ "./src/app/workspace/fluent/fluent.component.html"),
            styles: [__webpack_require__(/*! ./fluent.component.scss */ "./src/app/workspace/fluent/fluent.component.scss")],
        }),
        __metadata("design:paramtypes", [])
    ], FluentComponent);
    return FluentComponent;
}());



/***/ }),

/***/ "./src/app/workspace/fluent/fluent.module.ts":
/*!***************************************************!*\
  !*** ./src/app/workspace/fluent/fluent.module.ts ***!
  \***************************************************/
/*! exports provided: FluentModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "FluentModule", function() { return FluentModule; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _fluent_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./fluent.component */ "./src/app/workspace/fluent/fluent.component.ts");
/* harmony import */ var _fluent_routes__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./fluent.routes */ "./src/app/workspace/fluent/fluent.routes.ts");
/* harmony import */ var _common_services_app_side_menu_service__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../common/services/app-side-menu.service */ "./src/app/workspace/common/services/app-side-menu.service.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};







var FluentModule = /** @class */ (function () {
    function FluentModule() {
        this.typeMenu = 0;
    }
    FluentModule.prototype.buyHandler = function (event) {
        this.typeMenu = event;
    };
    FluentModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [
                _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormsModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_2__["ReactiveFormsModule"],
                _angular_common__WEBPACK_IMPORTED_MODULE_3__["CommonModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"].forChild(_fluent_routes__WEBPACK_IMPORTED_MODULE_5__["fluentRoutes"])
            ],
            exports: [],
            declarations: [
                _fluent_component__WEBPACK_IMPORTED_MODULE_4__["FluentComponent"],
            ],
            providers: [_common_services_app_side_menu_service__WEBPACK_IMPORTED_MODULE_6__["AppSideMenuService"]] //EventBusService,
        })
    ], FluentModule);
    return FluentModule;
}());



/***/ }),

/***/ "./src/app/workspace/fluent/fluent.routes.ts":
/*!***************************************************!*\
  !*** ./src/app/workspace/fluent/fluent.routes.ts ***!
  \***************************************************/
/*! exports provided: fluentRoutes */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "fluentRoutes", function() { return fluentRoutes; });
/* harmony import */ var _fluent_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./fluent.component */ "./src/app/workspace/fluent/fluent.component.ts");

//import { WorkspaceComponent } from './workspace.component';
//import {DashboardComponent} from "../workspace/dashboard/dashboard.component"
var fluentRoutes = [
    {
        path: '',
        component: _fluent_component__WEBPACK_IMPORTED_MODULE_0__["FluentComponent"],
        children: [
            { path: '', redirectTo: 'org', pathMatch: 'full' },
            { path: 'home', loadChildren: './home/home.module#HomeModule' },
        ]
    }
];


/***/ })

}]);
//# sourceMappingURL=workspace-fluent-fluent-module.js.map