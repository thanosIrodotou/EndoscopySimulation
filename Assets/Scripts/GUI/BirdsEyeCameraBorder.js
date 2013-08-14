#pragma strict
@script ExecuteInEditMode
 
var mySkin : GUISkin ;
 
function OnGUI(){
   if(mySkin)
      GUI.skin = mySkin ;
   var cam : Camera = transform.camera ;
   
   
   GUI.Box(Rect(0, 525, 265, 284), "") ;
}