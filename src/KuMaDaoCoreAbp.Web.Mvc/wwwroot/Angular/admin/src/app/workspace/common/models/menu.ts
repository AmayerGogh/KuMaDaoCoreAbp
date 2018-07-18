export class Menu{
   public  id: number;
   public  name: string;
   public  isOpen: boolean;
   public icon:string;
   public  children:Array<MenuDetail>;
   constructor(id:number,name:string,isOpen:boolean,icon:string,children:MenuDetail[] ){
        this.id=id,
        this.name =name,
        this.icon =icon,
        this.isOpen =isOpen,
        this.children =children
   }
}

export class MenuDetail{
   
   public  name:string;
   public  icon:string;
   public  route:string;
   constructor(name:string,icon:string,route:string ){
        this.name =name,
        this.icon =icon,
        this.route =route
  }
        // { name: "组织架构",icon:'fa-male',route:'org/orgmng'},
        // { name: "用户管理",icon:'fa-bug',route:'user/usertable/page/1' },
        // { name: "角色管理",icon:'fa-bus',route:'role/roletable/page/1' },
        // { name: "权限管理",icon:'fa-send',route:'permission/permissiontable/page/1' }
    
}