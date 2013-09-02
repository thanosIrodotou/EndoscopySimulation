using UnityEngine;
using System.Collections;

/**
 * This is the StartSceneGUI class. This class is the first class called by the simulation. 
 * It displays the starting menu where all buttons which lead to other scenes are available.
 * \author Athanasios Irodotou 2013
 */

public class StartSceneGUI : MonoBehaviour 
{
	
<<<<<<< HEAD
	private int spacing = 10; /**< How much vertical space separates the GUI elements. */
	public GUISkin mySkin;  /**< The mySkin variable is initialised in the Editor using a free, Unity provided set of GUI skins.  */
	private Rect scenarioWindowPopupRect = new Rect((Screen.width - 400)/2, (Screen.height - 550)/2, 370, 100); /**< Initialises the dimensions of a new Rect to display the "Choose Scenario" pop menu. */
	private Rect forceTutorialWindowPopupRect = new Rect((Screen.width - 400)/2, (Screen.height - 550)/2, 380, 100); /**< Initialises the dimensions for the Tutorial window pop up which is shown if the user clicks on Choose Scenario without going through Training first. */
	private bool showScenarioPopup = false; /**< A boolean variable to make sure the Choose Scenario pop up window is shown. */
	public static bool hasGoneThroughTutorial; /**< Another boolean variable which is true when the user goes through the Training Scenario sucessfully. This enforces the user to go through Training first. */
	private bool showForceTutorialPopup = false; /**< Boolean variable to check if the force tutorial pop up window is shown. */
	
=======
	private int spacing = 10;
	public GUISkin mySkin;
	private Rect scenarioWindowPopupRect = new Rect((Screen.width - 400)/2, (Screen.height - 550)/2, 370, 100);
	private bool showScenarioPopup = false;
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9

	// Use this for initialization
	/**
	 * The Start method is a MonoBehaviour inherited method called once when the scene which is included in is first loaded. 
	 * This method makes sure all required variables are initialised and are ready when the scene needs them.
	 */
	void Start () 
	{
		if (PlayerPrefs.GetInt("HasGoneThroughTutorial") == 1)
		{
			hasGoneThroughTutorial = true;	
		}		
		else
			hasGoneThroughTutorial = false;
	}
	
		
	/**
	 * Another MonoBehaviour inherited method loaded each frame to provide the necessary GUI drawcalls to check for GUI elements' changes and display them.
	 * This method provides all GUI elements, mostly buttons which lead to the rest scenes of the application.
	 */	
	void OnGUI () 
	{
		GUI.skin = mySkin;																			
		
		Event e = Event.current;	   
	 
	    if (e.type == EventType.MouseDown && !scenarioWindowPopupRect.Contains(e.mousePosition))
	    {
<<<<<<< HEAD
	       	showScenarioPopup = false;
			showForceTutorialPopup = false;
	    }

		if (showScenarioPopup)
			scenarioWindowPopupRect = GUILayout.Window(1, scenarioWindowPopupRect, scenarioPopup, "Simulation Scenarios", GUILayout.Width(370));				
		
		
		if (showForceTutorialPopup)
			forceTutorialWindowPopupRect = GUILayout.Window(2, forceTutorialWindowPopupRect, forceTutorialPopup, "Important Note", GUILayout.Width(380));	
		
		
		GUILayout.BeginArea(new Rect((Screen.width - 250)/2, (Screen.height - 250)/2, 250, 500));
		if(GUILayout.Button("Start Training", GUILayout.Width(250)))
=======
	       showScenarioPopup = false;
	    }

		if (showScenarioPopup)
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
		{
			scenarioWindowPopupRect = GUILayout.Window(1, scenarioWindowPopupRect, scenarioPopup, "Simulation Scenarios", GUILayout.Width(370));	
		}
		
<<<<<<< HEAD
		
		GUILayout.Space(spacing);		
		
		
		if(GUILayout.Button("Choose Senario", GUILayout.Width(250)))
		{
			if (hasGoneThroughTutorial)
			{
				showScenarioPopup = true;
			}		
			else
			{
				showForceTutorialPopup = true;
			}
=======
		GUILayout.BeginArea(new Rect((Screen.width - 250)/2, (Screen.height - 250)/2, 250, 500));
		if(GUILayout.Button("Start Training", GUILayout.Width(250)))
		{
			Application.LoadLevelAsync(6);
		}
		
//		GUILayout.Space(spacing);
//		
//		if(GUILayout.Button("Start Simulation", GUILayout.Width(250)))
//		{
//			Application.LoadLevelAsync(1);
//		}
//		
		GUILayout.Space(spacing);
		
		if(GUILayout.Button("Choose Senario", GUILayout.Width(250)))
		{
			showScenarioPopup = true;
//			Application.LoadLevelAsync(2);			
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
		}
		
		GUILayout.Space(spacing);
		
		if(GUILayout.Button("Options", GUILayout.Width(250)))
		{
			Application.LoadLevelAsync(3);
		}
		
		GUILayout.Space(spacing);
		
		if(GUILayout.Button("Simulation Statistics", GUILayout.Width(250)))
		{
			Application.LoadLevelAsync(8);
		}
		
		GUILayout.Space(spacing);
		
		if(GUILayout.Button("Credits", GUILayout.Width(250)))
		{
			Application.LoadLevelAsync(4);
		}
		
		GUILayout.Space(spacing);
		
		if(GUILayout.Button("Quit Simulation", GUILayout.Width(250)))
		{
			Application.Quit();
		}		
		
		GUILayout.EndArea();
	
	}
	
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
<<<<<<< HEAD
	
	/**
	 * The scenarioPopUp method composites a popup window to provide the user with the option to Choose a Simulation Scenario.
	 * \param windowID a unique integer number for the window's id.
	 */	
=======
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
	void scenarioPopup(int windowID)
	{
				
		GUILayout.Space(5);
		
		GUILayout.Label(
			"Choose a scenario from the list below.");				
		
		GUILayout.BeginHorizontal("");
<<<<<<< HEAD
		if(GUILayout.Button("Scenario 1. Low Realism", GUILayout.Width(185)))
=======
		if(GUILayout.Button("Scenario 1. Low Interaction", GUILayout.Width(185)))
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
		{			
			Application.LoadLevelAsync(1);
		}
		
		GUILayout.FlexibleSpace();
		
<<<<<<< HEAD
		if(GUILayout.Button("Scenario 2. High Realism", GUILayout.Width(185)))
=======
		if(GUILayout.Button("Scenario 2. High Interaction", GUILayout.Width(185)))
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
		{			
			Application.LoadLevelAsync(9);
		}
		
		GUILayout.EndHorizontal();		
	}
<<<<<<< HEAD
	
	
	/**
	 * This method is called if the user has not completed the Training, and displays a popup window which forces the user to go through training first.
	 * If the user has gone through training then the "scenarioPopUp" method described before is called.
	 * \param windowID a unique integer number for the window's id. 
	 */
	void forceTutorialPopup(int windowID)
	{
				
		GUILayout.Space(5);
		
		GUILayout.Label("It is advised  you go through the training scenario first.");				
		
		GUILayout.BeginHorizontal("");
		
		if(GUILayout.Button("Start Training Scenario"))
		{			
			Application.LoadLevelAsync(6);
		}	
		
		GUILayout.EndHorizontal();		
	}	
}
=======
}
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
