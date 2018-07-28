import { DefaultComponent } from "./default.component"
import { HomeComponent } from "@app/default/home/home.component";
import { AppRouteGuard } from "@shared/auth/auth-route-guard";
import { TenantsComponent } from "@app/default/tenants/tenants.component";
import { RolesComponent } from "@app/default/roles/roles.component";
import { UsersComponent } from "@app/default/users/users.component";

export const DefaultRoutes = [
    {
        path: '',
        component: DefaultComponent,
        children: [
            // { path: 'comment', loadChildren: '../comment/comment.module#CommentModule' },
            {
                path: 'home',
                component: HomeComponent,
                data: { translate: 'home' },
                canActivate: [AppRouteGuard],
            },
            {
                path: 'tenants',
                data: { translate: 'tenants' },
                component: TenantsComponent,
                canActivate: [AppRouteGuard],
            },
            {
                path: 'roles',
                data: { translate: 'roles' },
                component: RolesComponent,
                canActivate: [AppRouteGuard],
            },
            {
                path: 'users',
                data: { translate: 'users' },
                component: UsersComponent,
                canActivate: [AppRouteGuard],
            },
            { path: '', redirectTo: 'home', pathMatch: 'full' },
        ]
    }
];
