import {NgModule} from '@angular/core'
import {CommonModule} from '@angular/common'
import { RouterModule } from '@angular/router';

import {blogRoutes} from './blog.routes'
import {BlogComponent} from './blog.component'

@NgModule({
    imports:[
        CommonModule,
        RouterModule.forChild(blogRoutes)
    ],
    declarations:[
        BlogComponent
    ],
    providers:[

    ]
})
export class BlogModule{}
