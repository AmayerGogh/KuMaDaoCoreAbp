import { Component, OnInit } from "@angular/core";
import { DomSanitizer } from '@angular/platform-browser';

@Component({
    selector: 'frames',
    templateUrl: './frames.component.html',
    styles: [],
})
export class FramesComponent implements OnInit {
    ngOnInit(): void {

    }

    public orbitUrl: string;
    constructor(private sanitizer: DomSanitizer) {
        this.orbitUrl = "https://www.baidu.com";
    }
}