import { Component, OnInit } from '@angular/core';
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
  selector: 'default',
  templateUrl: './default.component.html',
  styles: []
})
export class DefaultComponent implements OnInit {
  ngOnInit(): void {

  }


}
