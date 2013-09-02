#pragma strict
@script ExecuteInEditMode
 
var mySkin : GUISkin ;
 
function OnGUI(){
   if(mySkin)
      GUI.skin = mySkin ;
   var cam : Camera = transform.camera ;
   
   
<<<<<<< HEAD
   GUI.Box(Rect(0, 795, 265, 284), "") ;
=======
   GUI.Box(Rect(0, 525, 265, 284), "") ;
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
}