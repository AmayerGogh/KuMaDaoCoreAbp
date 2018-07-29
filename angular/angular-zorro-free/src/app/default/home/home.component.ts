import { Component, Injector, AfterViewInit, OnInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { _HttpClient } from '@delon/theme';
import { NzMessageService } from "ng-zorro-antd"
import { zip } from 'rxjs';

@Component({
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.less'],

  animations: [appModuleAnimation()],
})
export class HomeComponent extends AppComponentBase implements OnInit {
  constructor(
    injector: Injector,
    private http: _HttpClient,
    public msg: NzMessageService,
  ) {
    super(injector);
  }


  notice: any[];
  loading = true;

  ngOnInit(): void {
    zip(this.http.get('/api/notice')).subscribe(([chart]: [any]) => {
      this.notice = chart;

      this.loading = false;
    });
  }
}
