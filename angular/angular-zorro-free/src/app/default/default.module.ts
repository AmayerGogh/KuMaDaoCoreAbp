import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { SharedModule } from '@shared/shared.module';
import { AbpModule } from 'abp-ng2-module/dist/src/abp.module';
import { LayoutModule } from '@app/layout/layout.module';
import { HttpClientModule } from '@angular/common/http';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule } from '@angular/router';
import { LocalizationService } from 'abp-ng2-module/dist/src/localization/localization.service';
import { HttpModule } from '@angular/http';

import { DefaultComponent } from '@app/default/default.component';
import { HomeComponent } from '@app/default/home/home.component';
import { TenantsComponent } from '@app/default/tenants/tenants.component';
import { UsersComponent } from '@app/default/users/users.component';
import { RolesComponent } from '@app/default/roles/roles.component';
import { CreateTenantComponent } from '@app/default/tenants/create-tenant/create-tenant.component';
import { EditTenantComponent } from '@app/default/tenants/edit-tenant/edit-tenant.component';
import { CreateRoleComponent } from '@app/default/roles/create-role/create-role.component';
import { EditRoleComponent } from '@app/default/roles/edit-role/edit-role.component';
import { CreateUserComponent } from '@app/default/users/create-user/create-user.component';
import { EditUserComponent } from '@app/default/users/edit-user/edit-user.component';

import { DefaultRoutes } from '@app/default/default.routes';

@NgModule({
    imports: [
        CommonModule,
        //BrowserModule,
        //BrowserAnimationsModule,
        HttpClientModule,

        LayoutModule,
        SharedModule,
        AbpModule,
        HttpModule,
        RouterModule.forChild(DefaultRoutes)
    ],
    declarations: [
        DefaultComponent,
        HomeComponent,
        TenantsComponent,
        UsersComponent,
        RolesComponent,
        CreateTenantComponent,
        EditTenantComponent,
        CreateRoleComponent,
        EditRoleComponent,
        CreateUserComponent,
        EditUserComponent,
    ],
    entryComponents: [ //这是干嘛的?
        CreateTenantComponent,
        EditTenantComponent,
        CreateRoleComponent,
        EditRoleComponent,
        CreateUserComponent,
        EditUserComponent,
    ],
    providers: [LocalizationService],
})
export class DefaultModule { }