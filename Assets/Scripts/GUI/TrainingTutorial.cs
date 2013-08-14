using UnityEngine;
using System.Collections;

public class TrainingTutorial : MonoBehaviour 
{
	public GUISkin mySkin;
	public GUIStyle titleStyle;
	public GUIStyle bodyStyle;
	private Rect tipWindowRect = new Rect((Screen.width - 450)/2, (Screen.height - 450)/2, 450, 200);
	private bool showTutWindow1;
	private bool showTutWindow2 = false;
	private bool showTutWindow3 = false;
	private bool showTutWindow4 = false;
	private bool isTutShowing = true;
	private int startScenario = 0;
	public static bool showGUIOverlays;
	public GameObject labelTagsToggle;
	public GameObject obstacleObject;
	public Texture lesionImage;
	public Texture lesionImage2;
	
	// Use this for initialization
	void Start () 
	{
		Time.timeScale = 0.0f;
		showTutWindow1 = true;
		showGUIOverlays = false;
		GameObject.Find("FrontCam").GetComponent<RaycastCollision>().enabled = false;		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	void OnGUI ()
	{		
		GUI.skin = mySkin;

		if (showTutWindow1)
		{
			tipWindowRect = GUILayout.Window(1, tipWindowRect, tipPopUp1, "Training Tutorial Introduction", GUILayout.Width(450), GUILayout.Height(390));	
		}	
		else if (showTutWindow2)
		{
			tipWindowRect = GUILayout.Window(1, tipWindowRect, tipPopUp2, "The GUI Elemens", GUILayout.Width(450), GUILayout.Height(390));
		}
		else if (showTutWindow3)
		{
			tipWindowRect = GUILayout.Window(1, tipWindowRect, tipPopUp3, "Dynamic Elements", GUILayout.Width(450), GUILayout.Height(390));
		}
		else if (showTutWindow4)
		{
			tipWindowRect = GUILayout.Window(1, tipWindowRect, tipPopUp4, "The Controls", GUILayout.Width(450), GUILayout.Height(380));
		}
	}
		
	void tipPopUp1(int windowID)
	{		
		GUILayout.Space(5);
		
		GUILayout.Label(
			"Tutorial Section 1."
			+ "\n" + "\n" + "This scenario will take you through a series of steps." 
			+ "\n" + "Through these steps, you will learn how to navigate within the 3d human model." 
			+ "While navigating the human body you will be presented with challeneges you need to complete." 
			+ "\n" + "\n" + "These challenges will help you understand "
			+ "when to use the different modules of the endoscope," 
			+ "as well as emphasise on important sections of the human body," 
			+ "which are of particular interest in Upper Endoscopy."
			+ "\n" + "\n"  + "Click next when comfortable to begin."
			, bodyStyle);	
		
		GUILayout.Space(10);			
		
		GUILayout.BeginHorizontal("");
		if(GUILayout.Button("Next"))
		{
			showTutWindow1 = false;
			showTutWindow2 = true;
			showGUIOverlays = true;
		}	
		GUILayout.EndHorizontal();
	}
	
	void tipPopUp2(int windowID)
	{		
		GUILayout.Space(5);
		
		GUILayout.Label(
			"Tutorial Section 2"			
			+ "\n" + "\n" + "As you can see the simulation's HUD (located at the top center of the screen) is activated." 
			+ "\n" + "Your HUD shows essential information regarding the operation and how good or bad you are doing." 
			+ "\n" + "\n" + "Starting from left to right, you can check your elapsed time since the simulation was started, the length in cm, representing " +
				"how far you traveled since start, the number of lesions you identified and collected and finally Discomfort Level, an abstract value " +
				 "indicating the amount of pain your patient has suffered." 
			, bodyStyle);	
						
		GUILayout.Space(10);		
		
		GUILayout.BeginHorizontal("");
		if(GUILayout.Button("Back", GUILayout.Width(170)))
		{			
			showTutWindow2 = false;
			showTutWindow1 = true;		
		}
		
		GUILayout.FlexibleSpace();
		
		if(GUILayout.Button("Next", GUILayout.Width(170)))
		{			
			showTutWindow2 = false;
			showTutWindow3 = true;					
		}
		
		GUILayout.EndHorizontal();
	}
	
	void tipPopUp3(int windowID)
	{		
		GUILayout.Space(5);
		
		GUILayout.Label(
			"Tutorial Section 3."			
			+ "\n" + "\n" + "Some elements will appear throughout " + "\n" +
				"the operation to simulate lesions " + "and/or " + "\n" +
				"areas of particular interest." 
			+ "\n" + "A type of lesion is shown on the right." 		
			
			+ "\n" + "\n" + "\n" + "Lesions can be identified and collected " + "\n" +
				"by pushing the endoscope towards them." 			
			+ "\n" + "Different kinds of lesions can be " + "\n" +
				"disolved by shooting water to them. " + "\n" +
				"An example of such " +	"lesions is presented " + "\n" +
				"on the right." 			
			, bodyStyle);			
		
		GUI.DrawTexture(new Rect(345, 82, 95, 100), lesionImage, ScaleMode.ScaleToFit, true, 0);
		GUI.DrawTexture(new Rect(345, 185, 95, 100), lesionImage2, ScaleMode.ScaleToFit, true, 0);
		
		GUILayout.Space(10);		
		
		GUILayout.BeginHorizontal("");
		if(GUILayout.Button("Back", GUILayout.Width(170)))
		{			
			showTutWindow3 = false;
			showTutWindow2 = true;		
		}
		
		GUILayout.FlexibleSpace();
		
		if(GUILayout.Button("Next", GUILayout.Width(170)))
		{			
			showTutWindow3 = false;
			showTutWindow4 = true;		
		}
		
		GUILayout.EndHorizontal();
	}
	
	void tipPopUp4(int windowID)
	{		
		GUILayout.Space(5);
		
		GUILayout.Label(
			"Tutorial Section 4."	
			+ "\n" + "\n" + "Mouse Controls:"
			+ "\n" + "Simply move the mouse forward to push the endoscope inside the 3d model or backward to pull it." 
			+ "\n" + "Left and right mouse movements rotate the tip of the endoscope."
			
			+ "\n" + "\n" + "Keyboard Controls:"
			+ "\n" + "Pressing the 'shift' key will activate the water spray. You can use this functionality to clear obstacles throughout the simulation." 			
			+ "\n" + "To activate the endoscope's side camera view, press the 'space bar' on your keyboard. Side view might be useful to check specific areas " +
				"like the 'Ampulla of Vater'. Pressing the 'b' key will bring up another view called the Bird's Eye View. This view comes from a camera above the human organs, showing the endoscope's position and current position. You can lock the horizontal movement of the endoscope's tip by pressing 'control'. This way you can easily " +
				"take a biopsy using the biopsy needle or focus on an interesting area."		
			, bodyStyle);	
		
		GUILayout.Space(10);
				
		GUILayout.BeginHorizontal("");
		if(GUILayout.Button("Back", GUILayout.Width(170)))
		{			
			showTutWindow4 = false;
			showTutWindow3 = true;		
		}
		
		GUILayout.FlexibleSpace();
		
		if(GUILayout.Button("Finish", GUILayout.Width(170)))
		{			
			showTutWindow4 = false;
			GameObject.Find("FrontCam").GetComponent<BlurEffect>().enabled = false;		
			GameObject.Find("FrontCam").GetComponent<RaycastCollision>().enabled = true;
			obstacleObject.SetActive(true);
			
			labelTagsToggle.SetActive(true);
			showGUIOverlays = true;
			Time.timeScale = 1.0f;
		}
		
		GUILayout.EndHorizontal();		
	}
}
