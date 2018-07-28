import {AbpComponent} from "@app/abp/abp.component"


export const AbpRoutes = [
	{
		path: '',
		component: AbpComponent,
		children: [
			{ path: '', redirectTo: 'abp', pathMatch: 'full' },
			// { path: 'dashboard', loadChildren: './dashboard/dashboard.module#DashboardModule' },
			// { path: 'org', loadChildren: './org/org.module#OrgModule' },
			// { path: 'blog', loadChildren: './blog/blog.module#BlogModule' },			
		]
	}
];
