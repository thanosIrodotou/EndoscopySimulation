using UnityEngine;
using System.Collections;

public class EndSimulationLowGUI : MonoBehaviour 
{
	
	public GUISkin mySkin;
	private Rect windowRect = new Rect((Screen.width - 300)/2, (Screen.height - 400)/2, 0, 0);
	public GUIStyle titleStyle;
	public GUIStyle bodyStyle;
	private bool togglePopUp = false;
	private string statsButtonText = "View overall statistics";

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
		
		if(GUILayout.Button("Quit Simulation", GUILayout.Width(250)))
		{
			Application.Quit();
		}
		
		GUILayout.EndArea();
	}
	
	void popUp(int windowID) 
	{
		GUILayout.Label("Last Operation Statistics", titleStyle);	
		GUILayout.Space(30);
		GUILayout.Label("Total Time: " + SimulationControllerLow.niceTime, bodyStyle);
		//GUILayout.Space(30);
		GUILayout.Label("Length Examined: " + SimulationControllerLow.length + " cm", bodyStyle);
		GUILayout.Label("Lesions Discovered: " + SimulationControllerLow.lesions, bodyStyle);
		GUILayout.Label("Patient Discomfort Estimate (1-10): " + SimulationControllerLow.discomfortLevel, bodyStyle);
	}
	
	void statsPopUp(int windowID) 
	{
		
		if (PlayerPrefs.HasKey("TimeSpent"))
		{
			GUILayout.Label("Overall Statistics", titleStyle);	
			GUILayout.Space(30);
			GUILayout.Label("Data taken on: " + PlayerPrefs.GetString("DateTimeDataTaken"), bodyStyle);
			GUILayout.Label("Current Scenario: " + PlayerPrefs.GetString("CurrentSimScenario"), bodyStyle);			
			GUILayout.Label("Simulation duration: " + PlayerPrefs.GetString("TimeSpent"), bodyStyle);
			GUILayout.Label("Length examined: " + TrainingController.length + " cm", bodyStyle);
			GUILayout.Label("Lesions discovered: " + TrainingController.lesions, bodyStyle);
			GUILayout.Label("Patient discomfort Estimate (1-10): " + TrainingController.discomfortLevel, bodyStyle);
		} 
		else 
		{
			GUILayout.Label("Recent Statistics", titleStyle);				
			GUILayout.Space(30);
			GUILayout.Label("No statistical information has been recorded yet.", bodyStyle);
		}
					
	}
}
