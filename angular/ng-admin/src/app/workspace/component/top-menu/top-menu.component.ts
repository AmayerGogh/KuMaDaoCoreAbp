import { Component, OnInit, ElementRef, HostListener, Output, EventEmitter } from '@angular/core';

import {EventBusService} from "../../common/services/event-bus.service"



@Component({
  selector: 'top-menu',
  templateUrl: './top-menu.component.html',
  styleUrls: ['./top-menu.component.scss']
})
export class TopMenuComponent implements OnInit {
  private toggleBtnStatus:boolean=false;
  public showTopMenu:boolean=false;
 //_menuService:MenuService;
  //
 // @Output()
 // public  buy:EventEmitter<number> =new  EventEmitter();

  constructor() { //private eventBusService: EventBusService
      
  }

  ngOnInit() {
 
  }

  public onTogglerClick(event):void{
    // this.toggleBtnStatus=!this.toggleBtnStatus;
    // this.eventBusService.topToggleBtn.next(this.toggleBtnStatus);
    // this.eventBusService.leftNav.next(1);
  }
  public onTogglerClick2(event):void{
    // this.toggleBtnStatus=!this.toggleBtnStatus;
    // this.eventBusService.topToggleBtn.next(this.toggleBtnStatus);
    // this.eventBusService.leftNav.next(2);
  }
  
}
