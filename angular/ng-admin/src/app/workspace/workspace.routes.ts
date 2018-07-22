import { WorkspaceComponent } from './workspace.component';
export const workspaceRoutes = [
	{
		path: '',
		component: WorkspaceComponent,
		children: [
			{ path: '', redirectTo: 'erp', pathMatch: 'full' },
			{path:'erp',loadChildren:"../workspace/erp/erp.module#ErpModule"},
			{path:'fluent',loadChildren:"../workspace/fluent/fluent.module#FluentModule"},
			//{ path: 'dashboard', loadChildren: '../workspace/dashboard/dashboard.module#DashboardModule' },
			//{ path: 'org', loadChildren: '../org/org.module#OrgModule' },
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
