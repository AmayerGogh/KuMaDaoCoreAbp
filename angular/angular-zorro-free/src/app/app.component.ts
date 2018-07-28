import { Component, OnInit } from '@angular/core';
import { SignalRAspNetCoreHelper } from '@shared/helpers/SignalRAspNetCoreHelper';
import { AppComponentBase } from '@shared/app-component-base';
import { Injector } from '@angular/core';
import { AfterViewInit } from '@angular/core';
import { SettingsService, TitleService, MenuService, Menu } from '@delon/theme';
import { Router } from '@angular/router';
import { NavigationEnd } from '@angular/router';
import { filter } from 'rxjs/operators';
import { HostBinding } from '@angular/core';
import { NzModalService, NzNotificationService } from 'ng-zorro-antd';
import { AppConsts } from '@shared/AppConsts';
import { MenuItem } from '@shared/layout/menu-item';

@Component({
  selector: 'app',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.less'],
})
export class AppComponent extends AppComponentBase
  implements OnInit, AfterViewInit {

  @HostBinding('class.layout-fixed')
  get isFixed() {
    return this.settings.layout.fixed;
  }
  @HostBinding('class.layout-boxed')
  get isBoxed() {
    return this.settings.layout.boxed;
  }
  @HostBinding('class.aside-collapsed')
  get isCollapsed() {
    return this.settings.layout.collapsed;
  }

  // 全局的菜单
  Menums = [
    // 首页
    new MenuItem(
      this.l('HomePage'),
      '',
      'anticon anticon-home',
      '/app/default/home'),
    new MenuItem("默认", '', "anticon anticon-home", "#", [
      // 租户
      new MenuItem(
        this.l('Tenants'),
        'Pages.Tenants',
        'anticon anticon-team',
        '/app/default/tenants',
      ),
      // 角色
      new MenuItem(
        this.l('Roles'),
        'Pages.Roles',
        'anticon anticon-safety',
        '/app/default/roles',
      ),
      // 用户
      new MenuItem(
        this.l('Users'),
        'Pages.Users',
        'anticon anticon-user',
        '/app/default/users',
      ),]),


  ];

  constructor(
    injector: Injector,
    private settings: SettingsService,
    private router: Router,
    private titleSrv: TitleService,
    private menuService: MenuService,
  ) {
    super(injector);

    // 创建菜单

    const arrMenu = new Array<Menu>();
    this.processMenu(arrMenu, this.Menums);
    this.menuService.add(arrMenu);
  }

  ngOnInit(): void {
    this.router.events
      .pipe(filter(evt => evt instanceof NavigationEnd))
      .subscribe(() => this.titleSrv.setTitle());

    // 注册通知信息
    // SignalRAspNetCoreHelper.initSignalR();
    // 触发通知事件
    // abp.event.on('abp.notifications.received', userNotification => {
    //   abp.notifications.showUiNotifyForUserNotification(userNotification);

    //   // Desktop notification
    //   Push.create('AbpZeroTemplate', {
    //     body: userNotification.notification.data.message,
    //     icon: abp.appPath + 'assets/app-logo-small.png',
    //     timeout: 6000,
    //     onClick: function () {
    //       window.focus();
    //       this.close();
    //     },
    //   });
    // });
  }

  ngAfterViewInit(): void {
    // ($ as any).AdminBSB.activateAll();
    // ($ as any).AdminBSB.activateDemo();
  }

  // 处理生成菜单
  processMenu(resMenu: Menu[], menus: MenuItem[], isChild?: boolean) {
    menus.forEach(item => {
      let subMenu: Menu;
      subMenu = {
        text: item.displayName,
        link: item.route,
        icon: `${item.icon}`,
        hide: item.hide,
      };
      if (item.permission !== '' && !this.isGranted(item.permission)) {
        subMenu.hide = true;
      }

      if (item.childMenus && item.childMenus.length > 0) {
        subMenu.children = [];
        this.processMenu(subMenu.children, item.childMenus);
      }

      resMenu.push(subMenu);
    });
  }

}
