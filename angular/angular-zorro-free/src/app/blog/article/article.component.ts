import { Component, OnInit } from "@angular/core";
import { DomSanitizer } from "@angular/platform-browser";

@Component({
    selector: 'article',
    templateUrl: './article.component.html',
    styles: [],
})
export class ArticleComponent implements OnInit {
    ngOnInit(): void {

    }

    public orbitUrl: string;
    constructor(private sanitizer: DomSanitizer) {
        this.orbitUrl = "http://localhost:62114/admin/article";
    }
}