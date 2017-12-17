import {FluentComponent} from "./fluent.component"

//import { WorkspaceComponent } from './workspace.component';
//import {DashboardComponent} from "../workspace/dashboard/dashboard.component"
export const fluentRoutes = [
	{
		path: '',
		component: FluentComponent,
		children: [
			{ path: '', redirectTo: 'org', pathMatch: 'full' },
			{ path: 'dashboard', loadChildren: './dashboard/dashboard.module#DashboardModule' },
			{ path: 'org', loadChildren: './org/org.module#OrgModule' },
			// { path: 'post', loadChildren: '../post/post.module#PostModule' },
			// { path: 'comment', loadChildren: '../comment/comment.module#CommentModule' },
		
			// { path: 'user', loadChildren: '../user/user.module#UserModule' },
			// { path: 'role', loadChildren: '../role/role.module#RoleModule' },
			// { path: 'permission', loadChildren: '../permission/permission.module#PermissionModule' },
			// { path: 'sys', loadChildren: '../sys/sys.module#SysModule' },
			// { path: 'map', loadChildren: '../map/map.module#MapModule' }
		]
	}
];
