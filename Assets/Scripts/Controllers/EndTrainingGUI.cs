using UnityEngine;
using System.Collections;

/**
 * This is the class which provides the functionality visible in the EndTrainingScene which is loaded when Training is finished.
 * \author Athanasios Irodotou 2013
 */
public class EndTrainingGUI : MonoBehaviour 
{
	
	public GUISkin mySkin; /**< The mySkin variable is initialised in the Editor using a free, Unity provided set of GUI skins. */
	private Rect windowRect = new Rect((Screen.width - 300)/2, (Screen.height - 400)/2, 0, 0); /**< Initialises the dimensions of a new Rect to display a pop up menu which displays statistics for the previous as well as all training sessions. */
	public GUIStyle titleStyle; /**<  The style variable creates a new component in Unity's Editor which provides the ability to customise a variety of styling options for selected GUI elemements. Font type, size, color and other information are some of the styling options. This variable is used to set the title's text label style. */
	public GUIStyle bodyStyle; /**<  The style variable creates a new component in Unity's Editor which provides the ability to customise a variety of styling options for selected GUI elemements. Font type, size, color and other information are some of the styling options. This variable is used to set the body's text label style. */

	// Use this for initialization
	void Start () 
	{
	
	}
	
	void Awake () 
	{
	}
	
	
	// Update is called once per frame
	
	void Update () 
	{
	
	}	
	
	
	/**
	 * Another MonoBehaviour inherited method loaded each frame to provide the necessary GUI drawcalls to check for GUI elements' changes and display them.
	 * This method provides all GUI elements. It draws a series of buttons to let the user restart the training scenario, select a simulation scenario, go back to main menu, etc.
	 */		
	void OnGUI () 
	{
		GUI.skin = mySkin;								

		windowRect = GUILayout.Window(0, windowRect, popUp, "", GUILayout.Width(300), GUILayout.Height(250));		

		GUILayout.BeginArea(new Rect((Screen.width -250)/2, (Screen.height + 150)/2, 250,250));
		if(GUILayout.Button("Restart Training?", GUILayout.Width(250)))
		{
			Application.LoadLevel(6);
		}
		
		GUILayout.Space(10);
		
		if(GUILayout.Button("Select Scenario", GUILayout.Width(250)))
		{
			ScenarioSceneGUI.cameFrom = "endTrainingGUI";
			Application.LoadLevel(2);
		}
		
		GUILayout.Space(10);
		
		if(GUILayout.Button("Main Menu", GUILayout.Width(250)))
		{
			Application.LoadLevel(0);
		}		
		
		GUILayout.Space(10);
		
		if(GUILayout.Button("Quit Simulation", GUILayout.Width(250)))
		{
			Application.Quit();
		}				
		
		GUILayout.EndArea();
	}
	
	
	/**
	 * The popUp method displays a new popup window to the user when called. 
	 * It presents a collection of statistics recorded in the previous training session.
	 * \param windowID a unique integer number for the window's id.
	 */	
	void popUp(int windowID) 
	{
		GUILayout.Label("Training Statistics", titleStyle);	
		GUILayout.Space(20);
		GUILayout.Label("Data taken on: " + PlayerPrefs.GetString("TrDateTimeDataTaken"), bodyStyle);	
		GUILayout.Space(5);
		GUILayout.Label("Current Scenario: " + PlayerPrefs.GetString("TrCurrentSimScenario"), bodyStyle);
		GUILayout.Space(5);
		GUILayout.Label("Total Time: " + PlayerPrefs.GetString("TrTimeSpent"), bodyStyle);
		GUILayout.Space(5);		
		GUILayout.Label("Length Examined: " + PlayerPrefs.GetFloat("TrSessionLengthTraveled") + " cm", bodyStyle);
		GUILayout.Space(5);
		GUILayout.Label("Lesions Discovered: " + PlayerPrefs.GetInt("TrSessionLesions"), bodyStyle);
		GUILayout.Space(5);
		GUILayout.Label("Patient Discomfort Estimate (1-10): " + PlayerPrefs.GetFloat("TrSessionDiscomfort"), bodyStyle);
	}
}
