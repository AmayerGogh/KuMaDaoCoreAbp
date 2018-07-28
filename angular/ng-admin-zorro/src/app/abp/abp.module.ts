import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { AbpRoutes } from '@app/abp/abp.routes';
@NgModule({
    imports: [
        CommonModule,
        RouterModule.forChild(AbpRoutes)
    ],
    exports: [],
    declarations: [
        AbpRoutes,    
    ],
    providers: [] //EventBusService,
})
export class AbpModule {
    
 }