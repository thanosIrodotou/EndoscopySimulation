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

		GUILayout.BeginArea(new Rect((Screen.width - 250)/2, (Screen.height - 250)/2, 250, 250));
		
		if(GUILayout.Button("Senario 1. LOD: Low", GUILayout.Width(250)))
		{
			Application.LoadLevelAsync(1);
		}
		
		GUILayout.Space(spacing);
		
		if(GUILayout.Button("Scenario 2. LOD: Medium", GUILayout.Width(250)))
		{
			Application.LoadLevelAsync(1);
		}
		
		GUILayout.Space(spacing);
		
		if(GUILayout.Button("Scenario 3. LOD: High", GUILayout.Width(250)))
		{
			Application.LoadLevelAsync(1);
		}
		
		GUILayout.Space(spacing);		
		
		if(GUILayout.Button("Back", GUILayout.Width(250)))
		{
			Application.LoadLevelAsync(0);
		}
		
		GUILayout.EndArea();
	}
}
