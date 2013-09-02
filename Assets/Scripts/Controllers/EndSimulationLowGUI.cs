using UnityEngine;
using System.Collections;

public class EndSimulationLowGUI : MonoBehaviour 
{
	
	public GUISkin mySkin; /**< The mySkin variable is initialised in the Editor using a free, Unity provided set of GUI skins. */
	private Rect windowRect = new Rect((Screen.width - 300)/2, (Screen.height - 400)/2, 0, 0); /**< Initialises the dimensions of a new Rect to display a pop up menu which displays statistics for the previous as well as all training sessions. */
	public GUIStyle titleStyle; /**<  The style variable creates a new component in Unity's Editor which provides the ability to customise a variety of styling options for selected GUI elemements. Font type, size, color and other information are some of the styling options. This variable is used to set the title's text label style. */
	public GUIStyle bodyStyle; /**<  The style variable creates a new component in Unity's Editor which provides the ability to customise a variety of styling options for selected GUI elemements. Font type, size, color and other information are some of the styling options. This variable is used to set the body's text label style. */
	private bool togglePopUp = false; /**< A boolean variable which is true if the session's statistics or the overall statistics are shown. */
	private string statsButtonText = "View overall statistics"; /**< A string value to toggle the view statistics button text to either "View overall statistics" or "View last statistics". */

	// Use this for initialization
	void Start () 
	{
		//Screen.SetResolution(1920, 1080, true, 60);	
		//print (Screen.width);
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
	 * This method provides all GUI elements. It draws a series of buttons to let the user restart the scenario, select a different one, quit, etc. 
	 * It also displays a window including either last operation's statistics or overall statistics for this scenario.
	 */		
	void OnGUI () 
	{
		GUI.skin = mySkin;								

		windowRect = GUILayout.Window(0, windowRect, popUp, "", GUILayout.Width(300), GUILayout.Height(250));		
		
		if (togglePopUp)
		{
			windowRect = GUILayout.Window(0, windowRect, statsPopUp, "", GUILayout.Width(300), GUILayout.Height(250));			
		}
		

		GUILayout.BeginArea(new Rect((Screen.width -250)/2, (Screen.height + 150)/2, 250,250));
		if(GUILayout.Button("Restart Scenario?", GUILayout.Width(250)))
		{
			Application.LoadLevel(1);
		}
		
		GUILayout.Space(10);
		
		if(GUILayout.Button("Select Scenario", GUILayout.Width(250)))
		{
			ScenarioSceneGUI.cameFrom = "endSimulationLowGUI";
			Application.LoadLevel(2);
		}
		
		GUILayout.Space(10);
		
		if (statsButtonText == "View overall statistics")
		{
			if(GUILayout.Button(statsButtonText, GUILayout.Width(250)))
			{
				togglePopUp = true;
				statsButtonText = "View last statistics";
			}				
		}			
		else if (statsButtonText == "View last statistics")
		{
			if(GUILayout.Button(statsButtonText, GUILayout.Width(250)))
			{
				togglePopUp = false;				
				statsButtonText = "View overall statistics";
			}			
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
	 * It presents a collection of statistics recorded in the last simulation operation.
	 * \param windowID a unique integer number for the window's id.
	 */		
	void popUp(int windowID) 
	{
		GUILayout.Label("Last Operation Statistics", titleStyle);	
		GUILayout.Space(20);
		GUILayout.Label("Total Time: " + PlayerPrefs.GetString("LowSessionTimeSpent"), bodyStyle);
		GUILayout.Space(5);		
		GUILayout.Label("Length Examined: " + PlayerPrefs.GetFloat("LowSessionLengthTraveled") + " cm", bodyStyle);
		GUILayout.Space(5);
		GUILayout.Label("Lesions Discovered: " + PlayerPrefs.GetInt("LowSessionLesions"), bodyStyle);
		GUILayout.Space(5);
		GUILayout.Label("Patient Discomfort Estimate (1-10): " + PlayerPrefs.GetFloat("LowSessionDiscomfort").ToString("F2"), bodyStyle);
	}
	
	
	/**
	 * The statsPopUp method displays a new popup window to the user when called. 
	 * It presents a summary of statistics for all simulation sessions in this scenario (Low).
	 * \param windowID a unique integer number for the window's id.
	 */		
	void statsPopUp(int windowID) 
	{
		
		if (PlayerPrefs.HasKey("LowDateTimeDataTaken"))
		{
			GUILayout.Label("Overall Statistics", titleStyle);	
			GUILayout.Space(20);
			GUILayout.Label("Data taken on: " + PlayerPrefs.GetString("LowDateTimeDataTaken"), bodyStyle);
			GUILayout.Space(5);
			GUILayout.Label("Current Scenario: " + PlayerPrefs.GetString("LowCurrentSimScenario"), bodyStyle);			
			GUILayout.Space(5);
			GUILayout.Label("Overall duration: " + PlayerPrefs.GetString("LowTimeSpent"), bodyStyle);
			GUILayout.Space(5);
			GUILayout.Label("Length examined: " + PlayerPrefs.GetFloat("LowLengthTraveled") + " cm", bodyStyle);
			GUILayout.Space(5);
			GUILayout.Label("Lesions discovered: " + PlayerPrefs.GetInt("LowLesions"), bodyStyle);
			GUILayout.Space(5);
			GUILayout.Label("Patient discomfort Estimate (1-10): " + PlayerPrefs.GetFloat("LowDiscomfort").ToString("F2"), bodyStyle);
		} 
		else 
		{
			GUILayout.Label("Recent Statistics", titleStyle);				
			GUILayout.Space(30);
			GUILayout.Label("No statistical information has been recorded yet.");
		}
					
	}
}