(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["common"],{

/***/ "./src/app/workspace/common/services/app-side-menu.service.ts":
/*!********************************************************************!*\
  !*** ./src/app/workspace/common/services/app-side-menu.service.ts ***!
  \********************************************************************/
/*! exports provided: AppSideMenuService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppSideMenuService", function() { return AppSideMenuService; });
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

var AppSideMenuService = /** @class */ (function () {
    function AppSideMenuService() {
        this.menu1 = [
            {
                id: 1,
                name: "首页",
                isOpen: false,
                icon: 'fa-home',
                children: []
            },
            {
                id: 4,
                name: "控制面板",
                isOpen: false,
                icon: 'fa-wrench',
                children: [
                    { name: "Colors", icon: 'fa-male', route: 'org/orgmng' },
                    { name: "Icons", icon: 'fa-bug', route: 'user/usertable/page/1' },
                    { name: "Animation", icon: 'fa-bus', route: 'role/roletable/page/1' },
                    { name: "Acrylic", icon: 'fa-send', route: 'permission/permissiontable/page/1' },
                    { name: "Typography", icon: 'fa-send', route: 'permission/permissiontable/page/1' },
                    { name: "Fonts", icon: 'fa-send', route: 'permission/permissiontable/page/1' },
                    { name: "Styling Components", icon: 'fa-send', route: 'permission/permissiontable/page/1' },
                    { name: "Custom Theme", icon: 'fa-send', route: 'permission/permissiontable/page/1' },
                ]
            }
        ];
        this.menu2 = [
            {
                id: 2,
                name: "Styles",
                isOpen: false,
                icon: 'fa-home',
                children: [
                    { name: "Colors", icon: 'fa-male', route: 'org/orgmng' },
                    { name: "Icons", icon: 'fa-bug', route: 'user/usertable/page/1' },
                    { name: "Animation", icon: 'fa-bus', route: 'role/roletable/page/1' },
                    { name: "Acrylic", icon: 'fa-send', route: 'permission/permissiontable/page/1' },
                    { name: "Typography", icon: 'fa-send', route: 'permission/permissiontable/page/1' },
                    { name: "Fonts", icon: 'fa-send', route: 'permission/permissiontable/page/1' },
                    { name: "Styling Components", icon: 'fa-send', route: 'permission/permissiontable/page/1' },
                    { name: "Custom Theme", icon: 'fa-send', route: 'permission/permissiontable/page/1' },
                ]
            },
            {
                id: 3,
                name: "Components",
                isOpen: false,
                icon: 'fa-magic',
                children: [
                    { name: "Animate", icon: 'fa-mobile', route: 'post/posttable/page/1' },
                    { name: "AppBarButton", icon: 'fa-minus', route: 'comment/commenttable/page/1' },
                    { name: "AutoSuggestBox", icon: 'fa-minus', route: 'comment/commenttable/page/1' },
                    { name: "Button", icon: 'fa-minus', route: 'comment/commenttable/page/1' },
                    { name: "CheckBox", icon: 'fa-minus', route: 'comment/commenttable/page/1' },
                    { name: "ColorPicker", icon: 'fa-minus', route: 'comment/commenttable/page/1' },
                    { name: "CommandBar", icon: 'fa-minus', route: 'comment/commenttable/page/1' },
                    { name: "ContentDialog", icon: 'fa-minus', route: 'comment/commenttable/page/1' },
                    { name: "DatePickers", icon: 'fa-minus', route: 'comment/commenttable/page/1' },
                    { name: "DropDownMenu", icon: 'fa-minus', route: 'comment/commenttable/page/1' },
                    { name: "FlipView", icon: 'fa-minus', route: 'comment/commenttable/page/1' },
                    { name: "Flyout", icon: 'fa-minus', route: 'comment/commenttable/page/1' },
                    { name: "Button", icon: 'fa-minus', route: 'comment/commenttable/page/1' },
                ]
            },
            {
                id: 4,
                name: "系统监控",
                isOpen: false,
                icon: 'fa-wrench',
                children: [
                    { name: "系统状态", icon: 'fa-line-chart', route: 'sys/sysmonitor' },
                    { name: "高德地图", icon: 'fa-map-marker', route: 'map/map' }
                ]
            }
        ];
    }
    AppSideMenuService.prototype.getMenu = function (type) {
        if (type == 1) {
            return this.menu1;
        }
        else if (type == 2) {
            return this.menu2;
        }
    };
    AppSideMenuService = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Injectable"])(),
        __metadata("design:paramtypes", [])
    ], AppSideMenuService);
    return AppSideMenuService;
}());



/***/ })

}]);
//# sourceMappingURL=common.js.map