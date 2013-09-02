#pragma strict
@script ExecuteInEditMode
 
var mySkin : GUISkin ;
 
function OnGUI(){
   if(mySkin)
      GUI.skin = mySkin ;
   var cam : Camera = transform.camera ;
   
   
<<<<<<< HEAD
   GUI.Box(Rect(1650, 795, 265, 286), "") ;
=======
   GUI.Box(Rect(1170, 525, 265, 286), "") ;
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
}