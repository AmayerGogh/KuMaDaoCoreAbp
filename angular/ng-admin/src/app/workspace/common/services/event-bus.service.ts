import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Subject } from 'rxjs';
/**
 * 事件总线，组件之间可以通过这个服务进行通讯
 */
@Injectable()
export class EventBusService {
    public topToggleBtn:Subject<boolean> = new Subject<boolean>();
    public leftNav:Subject<number> =new   Subject<number>();
    
    constructor() { }
}