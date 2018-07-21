import {BlogComponent} from './blog.component'

export const blogRoutes=[{
    path:"",
    component: BlogComponent,
	children: [
		//{ path: '', redirectTo: 'blog', pathMatch: 'full' },
		{ path: 'blog', component: BlogComponent }
	]
}]