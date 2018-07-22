import { Component, OnInit } from '@angular/core';
//import {NgLayer, NgLayerRef, NgLayerComponent} from "angular2-layer";
import {TopMenuComponent} from "../../component/top-menu/top-menu.component"
@Component({
  selector: 'org',
  templateUrl: './org.component.html',
  styleUrls: ['./org.component.scss']
})
export class OrgComponent implements OnInit {

 // constructor(private ly:NgLayer) {}
  
  config:any = {
      inSelector:"fallDown",
      outSelector:"rollOut",
      title:"angular2 layer",
      align:"top",
      parent: this,
      dialogComponent:TopMenuComponent,
      closeAble: false
  }
  ngOnInit(){
    
  }
  dialog(){
      //this.ly.dialog(this.config);
  }
  
  alert(){
     // this.ly.alert(this.config);
  }
  
  confirm(){
     // this.ly.confirm(this.config);
  }
  
  loading(){
     // let tip = this.ly.loading(this.config);
      
     // setTimeout(()=>{tip.close();}, 2000)
  }
  
  tip(){
     // this.ly.tip(this.config);
  }

}
