(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["org-org-module"],{

/***/ "./src/app/workspace/erp/org/org-mng/org-mng.component.html":
/*!******************************************************************!*\
  !*** ./src/app/workspace/erp/org/org-mng/org-mng.component.html ***!
  \******************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<h1>org</h1>"

/***/ }),

/***/ "./src/app/workspace/erp/org/org-mng/org-mng.component.scss":
/*!******************************************************************!*\
  !*** ./src/app/workspace/erp/org/org-mng/org-mng.component.scss ***!
  \******************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/workspace/erp/org/org-mng/org-mng.component.ts":
/*!****************************************************************!*\
  !*** ./src/app/workspace/erp/org/org-mng/org-mng.component.ts ***!
  \****************************************************************/
/*! exports provided: OrgMngComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "OrgMngComponent", function() { return OrgMngComponent; });
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

var OrgMngComponent = /** @class */ (function () {
    function OrgMngComponent() {
        this.disabled = true;
        this.isNew = false;
    }
    OrgMngComponent.prototype.ngOnInit = function () {
    };
    OrgMngComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'org-mng',
            template: __webpack_require__(/*! ./org-mng.component.html */ "./src/app/workspace/erp/org/org-mng/org-mng.component.html"),
            styles: [__webpack_require__(/*! ./org-mng.component.scss */ "./src/app/workspace/erp/org/org-mng/org-mng.component.scss")],
        }),
        __metadata("design:paramtypes", [])
    ], OrgMngComponent);
    return OrgMngComponent;
}());



/***/ }),

/***/ "./src/app/workspace/erp/org/org.component.html":
/*!******************************************************!*\
  !*** ./src/app/workspace/erp/org/org.component.html ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<router-outlet></router-outlet>\r\n"

/***/ }),

/***/ "./src/app/workspace/erp/org/org.component.scss":
/*!******************************************************!*\
  !*** ./src/app/workspace/erp/org/org.component.scss ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/workspace/erp/org/org.component.ts":
/*!****************************************************!*\
  !*** ./src/app/workspace/erp/org/org.component.ts ***!
  \****************************************************/
/*! exports provided: OrgComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "OrgComponent", function() { return OrgComponent; });
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

var OrgComponent = /** @class */ (function () {
    function OrgComponent() {
    }
    OrgComponent.prototype.ngOnInit = function () {
    };
    OrgComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'org',
            template: __webpack_require__(/*! ./org.component.html */ "./src/app/workspace/erp/org/org.component.html"),
            styles: [__webpack_require__(/*! ./org.component.scss */ "./src/app/workspace/erp/org/org.component.scss")]
        }),
        __metadata("design:paramtypes", [])
    ], OrgComponent);
    return OrgComponent;
}());



/***/ }),

/***/ "./src/app/workspace/erp/org/org.module.ts":
/*!*************************************************!*\
  !*** ./src/app/workspace/erp/org/org.module.ts ***!
  \*************************************************/
/*! exports provided: OrgModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "OrgModule", function() { return OrgModule; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _org_routes__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./org.routes */ "./src/app/workspace/erp/org/org.routes.ts");
/* harmony import */ var _org_mng_org_mng_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./org-mng/org-mng.component */ "./src/app/workspace/erp/org/org-mng/org-mng.component.ts");
/* harmony import */ var _org_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./org.component */ "./src/app/workspace/erp/org/org.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};






var OrgModule = /** @class */ (function () {
    function OrgModule() {
    }
    OrgModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_1__["CommonModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"].forChild(_org_routes__WEBPACK_IMPORTED_MODULE_3__["orgRoutes"])
            ],
            declarations: [
                _org_component__WEBPACK_IMPORTED_MODULE_5__["OrgComponent"],
                _org_mng_org_mng_component__WEBPACK_IMPORTED_MODULE_4__["OrgMngComponent"]
            ],
            providers: []
        })
    ], OrgModule);
    return OrgModule;
}());



/***/ }),

/***/ "./src/app/workspace/erp/org/org.routes.ts":
/*!*************************************************!*\
  !*** ./src/app/workspace/erp/org/org.routes.ts ***!
  \*************************************************/
/*! exports provided: orgRoutes */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "orgRoutes", function() { return orgRoutes; });
/* harmony import */ var _org_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./org.component */ "./src/app/workspace/erp/org/org.component.ts");
/* harmony import */ var _org_mng_org_mng_component__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./org-mng/org-mng.component */ "./src/app/workspace/erp/org/org-mng/org-mng.component.ts");


var orgRoutes = [{
        path: '',
        component: _org_component__WEBPACK_IMPORTED_MODULE_0__["OrgComponent"],
        children: [
            { path: '', redirectTo: 'orgmng', pathMatch: 'full' },
            { path: 'orgmng', component: _org_mng_org_mng_component__WEBPACK_IMPORTED_MODULE_1__["OrgMngComponent"] }
        ]
    }];


/***/ })

}]);
//# sourceMappingURL=org-org-module.js.map