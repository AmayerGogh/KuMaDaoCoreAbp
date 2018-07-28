
import { NgModule, Injector, LOCALE_ID, APP_INITIALIZER } from '@angular/core';
import { CommonModule, PlatformLocation } from '@angular/common'; //新加
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { AppSessionService } from '@shared/session/app-session.service';  //新加
import { AppPreBootstrap } from 'AppPreBootstrap';                        //新加
import { AppConsts } from '@shared/AppConsts';                            //新加

import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { DelonModule } from 'delon.module';
//import { CoreModule } from './core/core.module';
import { SharedModule } from '@shared/shared.module';
//import { SharedModule } from './shared/shared.module';
//import { RoutesModule } from './routes/routes.module';
//import { LayoutModule } from './layout/layout.module';
import { NgZorroAntdModule } from 'ng-zorro-antd';   //新加

import { ServiceProxyModule } from '@shared/service-proxies/service-proxy.module';

import { AbpHttpInterceptor } from 'abp-ng2-module/dist/src/abpHttpInterceptor';
import { API_BASE_URL } from '@shared/service-proxies/service-proxies';
import { AbpModule } from 'abp-ng2-module/dist/src/abp.module';

import { RootRoutingModule } from 'root-routing.module';
import { AppModule } from '@app/app.module';
import { RootComponent } from 'root.component';




export function appInitializerFactory(injector: Injector) {
  return () => {
    //  abp.ui.setBusy();
    // tslint:disable-next-line:no-shadowed-variable
    return new Promise<boolean>((resolve, reject) => {
      AppPreBootstrap.run(() => {
        abp.event.trigger('abp.dynamicScriptsInitialized');
        const appSessionService: AppSessionService = injector.get(
          AppSessionService,
        );
        appSessionService.init().then(
          result => {
            abp.ui.clearBusy();
            resolve(result);
          },
          err => {
            //   abp.ui.clearBusy();
            reject(err);
          },
        );
      });
    });
  };
}

export function getRemoteServiceBaseUrl(): string {
  return AppConsts.remoteServiceBaseUrl;
}

export function getCurrentLanguage(): string {
  return abp.localization.currentLanguage.name;
}
@NgModule({
  imports: [
    CommonModule,
    BrowserAnimationsModule,
    BrowserModule,
    AbpModule,
    // 引入DelonMdule
    DelonModule.forRoot(),
    ServiceProxyModule,
    RootRoutingModule,
    HttpClientModule,
    /** 导入 ng-zorro-antd 模块 **/
    NgZorroAntdModule,
    /** 必须导入 ng-zorro 才能导入此项 */
    SharedModule.forRoot(),   //这个需要forroot么
    AppModule,
  ],
  declarations: [RootComponent],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: AbpHttpInterceptor, multi: true },
    { provide: API_BASE_URL, useFactory: getRemoteServiceBaseUrl },
    {
      provide: APP_INITIALIZER,
      useFactory: appInitializerFactory,
      deps: [Injector],
      multi: true,
    },
    {
      provide: LOCALE_ID,
      useFactory: getCurrentLanguage,
    },
  ],
  bootstrap: [RootComponent],
})
export class RootModule { }
