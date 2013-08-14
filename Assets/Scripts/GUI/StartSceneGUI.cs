using UnityEngine;
using System.Collections;

public class StartSceneGUI : MonoBehaviour 
{
	
	private int spacing = 10;
	public GUISkin mySkin;
	private Rect scenarioWindowPopupRect = new Rect((Screen.width - 400)/2, (Screen.height - 550)/2, 370, 100);
	private bool showScenarioPopup = false;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void OnGUI () 
	{
		GUI.skin = mySkin;																			
		
		Event e = Event.current;	   
	 
	    if (e.type == EventType.MouseDown && !scenarioWindowPopupRect.Contains(e.mousePosition))
	    {
	       showScenarioPopup = false;
	    }

		if (showScenarioPopup)
		{
			scenarioWindowPopupRect = GUILayout.Window(1, scenarioWindowPopupRect, scenarioPopup, "Simulation Scenarios", GUILayout.Width(370));	
		}
		
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
		GUILayout.EndArea();
	
	}
	
	void Update () 
	{
		
	}
	
	void scenarioPopup(int windowID)
	{
				
		GUILayout.Space(5);
		
		GUILayout.Label(
			"Choose a scenario from the list below.");				
		
		GUILayout.BeginHorizontal("");
		if(GUILayout.Button("Scenario 1. Low Interaction", GUILayout.Width(185)))
		{			
			Application.LoadLevelAsync(1);
		}
		
		GUILayout.FlexibleSpace();
		
		if(GUILayout.Button("Scenario 2. High Interaction", GUILayout.Width(185)))
		{			
			Application.LoadLevelAsync(9);
		}
		
		GUILayout.EndHorizontal();		
	}
}
