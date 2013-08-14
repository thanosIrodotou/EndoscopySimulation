using UnityEngine;
using System.Collections;

public class EndTrainingGUI : MonoBehaviour 
{
	
	public GUISkin mySkin;
	private Rect windowRect = new Rect((Screen.width - 300)/2, (Screen.height - 400)/2, 0, 0);
	public GUIStyle titleStyle;
	public GUIStyle bodyStyle;

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
