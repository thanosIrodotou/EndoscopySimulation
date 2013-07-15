using UnityEngine;
using System.Collections;

public class OptionsSceneGUI : MonoBehaviour 
{

	public GUISkin mySkin;

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
		
		if(GUILayout.Button("Back", GUILayout.Width(250)))
		{
			Application.LoadLevelAsync(0);
		}
		
		GUILayout.EndArea();
	}
}
