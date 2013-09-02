using UnityEngine;
using System.Collections;

/**
 * This is the ScenarioSceneGUI class. This class is called when either the Training, SimulationLow, or SimulationHigh scenariosare finished and the user clicks on the "Select Scenario" butotn.
 * This class presents the two scenario options (Low & High Realism) for the user to either repeat a scenario or select a new one.
 * \author Athanasios Irodotou 2013
 */

public class ScenarioSceneGUI : MonoBehaviour 
{
	
	public GUISkin mySkin; /**< The mySkin variable is initialised in the Editor using a free, Unity provided set of GUI skins.  */
	private int spacing = 10; /**< How much vertical space separates the GUI elements. */
	public static string cameFrom; /**< A string value that stores the scenario the user came from. This we the application knows what options to render in the GUI. */
	
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	/**
	 * Another MonoBehaviour inherited method loaded each frame to provide the necessary GUI drawcalls to check for GUI elements' changes and display them.
	 * This method draws all GUI elements in the screen to provide buttons for the user to select.
	 */		
	void OnGUI () 
	{
		GUI.skin = mySkin;								

		GUILayout.BeginArea(new Rect((Screen.width - 300)/2, (Screen.height - 250)/2, 350, 250));
		
//		if(GUILayout.Button("Senario 1. Navigation & Controls Introduction", GUILayout.Width(300)))
//		{
//			Application.LoadLevelAsync(6);
//		}
//		
//		GUILayout.Space(spacing);
		
		if(GUILayout.Button("Scenario 1. Low Realism", GUILayout.Width(300)))
		{
			Application.LoadLevelAsync(1);
		}
		
		GUILayout.Space(spacing);
		
		if(GUILayout.Button("Scenario 2. High Realism", GUILayout.Width(300)))
		{
			Application.LoadLevelAsync(9);
		}
		
		GUILayout.Space(spacing);		
		
		if(GUILayout.Button("Back", GUILayout.Width(300)))
		{
			if (cameFrom == "endSimulationLowGUI")
			{
				Application.LoadLevelAsync(5);	
			}
			else if (cameFrom == "endSimulationHighGUI")
			{
				Application.LoadLevelAsync(10);
			}
			else if (cameFrom == "endTrainingGUI")
			{
				Application.LoadLevelAsync(7);
			}
			else 
			{
				Application.LoadLevelAsync(0);
			}
			
		}
		
		GUILayout.EndArea();
	}
}
