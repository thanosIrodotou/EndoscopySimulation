using UnityEngine;
using System.Collections;

public class ScenarioSceneGUI : MonoBehaviour 
{
	
	public GUISkin mySkin;
	private int spacing = 10;	

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI () 
	{
		GUI.skin = mySkin;								

		GUILayout.BeginArea(new Rect((Screen.width - 300)/2, (Screen.height - 250)/2, 350, 250));
		
		if(GUILayout.Button("Senario 1. Navigation & Controls Introduction", GUILayout.Width(300)))
		{
			Application.LoadLevelAsync(6);
		}
		
		GUILayout.Space(spacing);
		
		if(GUILayout.Button("Scenario 2. Low Interaction", GUILayout.Width(300)))
		{
			Application.LoadLevelAsync(1);
		}
		
		GUILayout.Space(spacing);
		
		if(GUILayout.Button("Scenario 3. High Interaction", GUILayout.Width(300)))
		{
			Application.LoadLevelAsync(9);
		}
		
		GUILayout.Space(spacing);		
		
		if(GUILayout.Button("Back", GUILayout.Width(300)))
		{
			Application.LoadLevelAsync(0);
		}
		
		GUILayout.EndArea();
	}
}
