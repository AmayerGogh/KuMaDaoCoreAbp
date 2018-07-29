
import { BlogComponent } from "@app/blog/blog.component";
import { ArticleComponent } from "@app/blog/article/article.component";
import { ArticleCategoryComponent } from "@app/blog/article-category/article-category.component";
import { FramesComponent } from "@app/blog/frames/frames.component";

export const BlogRoutes = [
    {
        path: '',
        component: BlogComponent,
        children: [
            // // { path: 'comment', loadChildren: '../comment/comment.module#CommentModule' },
            {
                path: 'article',
                component: ArticleComponent,
                data: { translate: 'article' },
            },
            {
                path: 'frames',
                component: FramesComponent,
                data: { translate: 'frames' },
            },
            {
                path: 'articleCategory',
                component: ArticleCategoryComponent,
                data: { translate: 'articleCategory' },
            },
            // {
            //     path: 'tenants',
            //     data: { translate: 'tenants' },
            //     component: TenantsComponent,
            //     canActivate: [AppRouteGuard],
            // },
            // {
            //     path: 'roles',
            //     data: { translate: 'roles' },
            //     component: RolesComponent,
            //     canActivate: [AppRouteGuard],
            // },
            // {
            //     path: 'users',
            //     data: { translate: 'users' },
            //     component: UsersComponent,
            //     canActivate: [AppRouteGuard],
            // },
            // { path: '', redirectTo: 'home', pathMatch: 'full' },
        ]
    }
];
