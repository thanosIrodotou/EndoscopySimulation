#pragma strict
@script ExecuteInEditMode
 
var mySkin : GUISkin ;
 
function OnGUI(){
   if(mySkin)
      GUI.skin = mySkin ;
   var cam : Camera = transform.camera ;
   
   
   GUI.Box(Rect(1170, 525, 265, 286), "") ;
}