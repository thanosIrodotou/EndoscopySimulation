using UnityEngine;
using System.Collections;

public class StartSceneGUI : MonoBehaviour 
{
	
	private int spacing = 10;
	public GUISkin mySkin;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void OnGUI () 
	{
		GUI.skin = mySkin;																			

		GUILayout.BeginArea(new Rect((Screen.width - 250)/2, (Screen.height - 250)/2, 250, 500));
		if(GUILayout.Button("Start Training", GUILayout.Width(250)))
		{
			Application.LoadLevelAsync(6);
		}
		
		GUILayout.Space(spacing);
		
		if(GUILayout.Button("Start Simulation", GUILayout.Width(250)))
		{
			Application.LoadLevelAsync(1);
		}
		
		GUILayout.Space(spacing);
		
		if(GUILayout.Button("Choose Senario", GUILayout.Width(250)))
		{
			Application.LoadLevelAsync(2);
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
}
