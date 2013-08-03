using UnityEngine;
using System.Collections;

public class TrainingTutorial : MonoBehaviour 
{
	public GUISkin mySkin;
	public GUIStyle titleStyle;
	public GUIStyle bodyStyle;
	private Rect tipWindowRect = new Rect((Screen.width - 350)/2, (Screen.height - 400)/2, 350, 200);
	private bool showTutWindow1;
	private bool showTutWindow2 = false;
	private bool showTutWindow3 = false;
	private bool showTutWindow4 = false;
	private bool isTutShowing = true;
	private int startScenario = 0;
	public static bool showGUIOverlays;
	public GameObject labelTagsToggle;
	public Texture lesionImage;
	public Texture lesionImage2;
	
	// Use this for initialization
	void Start () 
	{
		showTutWindow1 = true;
		showGUIOverlays = false;
		GameObject.Find("FrontCam").GetComponent<RaycastCollision>().enabled = false;		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Time.timeScale = startScenario;
	}
	
	void OnGUI ()
	{		
		GUI.skin = mySkin;

		if (showTutWindow1)
		{
			tipWindowRect = GUILayout.Window(1, tipWindowRect, tipPopUp1, "Training Tutorial Introduction", GUILayout.Width(350));	
		}	
		else if (showTutWindow2)
		{
			tipWindowRect = GUILayout.Window(1, tipWindowRect, tipPopUp2, "The GUI Elemens", GUILayout.Width(350));
		}
		else if (showTutWindow3)
		{
			tipWindowRect = GUILayout.Window(1, tipWindowRect, tipPopUp3, "Dynamic Elements", GUILayout.Width(350));
		}
		else if (showTutWindow4)
		{
			tipWindowRect = GUILayout.Window(1, tipWindowRect, tipPopUp4, "The Controls", GUILayout.Width(350));
		}
	}
		
	void tipPopUp1(int windowID)
	{		
		GUILayout.Space(5);
		
		GUILayout.Label(
			"Tutorial Section 1."
			+ "\n" + "\n" + "This scenario will take you through a series of steps." 
			+ "\n" + "Through these steps, you will learn how to navigate within the 3d human model." 
			+ "\n" + "While navigating the human body you will be presented with challeneges you need to complete." 
			+ "\n" + "These challenges will help you understand "
			+ "when to use the different modules of the endoscope," 
			+ "\n" + "as well as emphasise on important sections of the human body," 
			+ "\n" + "which are of particular interest in Upper Endoscopy."
			+ "\n"  + "Click next when comfortable to begin"
			, bodyStyle);	
		
		GUILayout.Space(10);			
		
		GUILayout.BeginHorizontal("");
		if(GUILayout.Button("Next", GUILayout.Width(350)))
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
				"on bottom right." 			
			, bodyStyle);
		
		GUILayout.Space(10);
		
		GUI.DrawTexture(new Rect(280, 82, 95, 100), lesionImage, ScaleMode.ScaleToFit, true, 0);
		GUI.DrawTexture(new Rect(280, 185, 95, 100), lesionImage2, ScaleMode.ScaleToFit, true, 0);
		
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
			, bodyStyle);	
		
		GUILayout.Space(180);
		
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
			labelTagsToggle.SetActive(true);
			showGUIOverlays = true;
			startScenario = 1;
		}
		
		GUILayout.EndHorizontal();
	}
}
