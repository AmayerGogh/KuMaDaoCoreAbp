
import { DefaultRoutes } from '@app/default/default.routes';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { LayoutModule } from '@app/layout/layout.module';
import { AbpModule } from 'abp-ng2-module/dist/src/abp.module';
import { SharedModule } from '@shared/shared.module';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { LocalizationService } from 'abp-ng2-module/dist/src/localization/localization.service';

import { BlogRoutes } from '@app/blog/blog.routers';
import { ArticleComponent } from "@app/blog/article/article.component"
import { BlogComponent } from '@app/blog/blog.component';
import { SafePipe } from '@app/blog/safePipe';
import { ArticleCategoryComponent } from '@app/blog/article-category/article-category.component';
import { FramesComponent } from '@app/blog/frames/frames.component';


@NgModule({
    imports: [
        CommonModule,
        HttpClientModule,
        LayoutModule,
        SharedModule,
        AbpModule,
        HttpModule,
        RouterModule.forChild(BlogRoutes)
    ],
    declarations: [
        BlogComponent,
        ArticleComponent,
        FramesComponent,
        ArticleCategoryComponent,
        SafePipe
    ],
    entryComponents: [ //这是干嘛的?

    ],
    providers: [LocalizationService],
})
export class BlogModule { }