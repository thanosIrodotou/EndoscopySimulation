using UnityEngine;
using System.Collections;

public class CreditsSceneGUI : MonoBehaviour 
{
	
	public GUISkin mySkin;
	public GUIStyle style;

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

		GUILayout.BeginArea(new Rect((Screen.width - 260)/2, (Screen.height - 250)/2, 260, 250));
		
		GUILayout.Label("Developer: Athanasios Irodotou", style);
		GUILayout.Space(3);
		GUILayout.Label("3D Models: Athanasios Irodotou", style);					
		GUILayout.Space(3);
		GUILayout.Label("GUI Skins: Unity Technologies", style);
		
		GUILayout.Space(10f);
		
		if(GUILayout.Button("Back", GUILayout.Width(250)))
		{
			Application.LoadLevelAsync(0);
		}
		
		GUILayout.EndArea();
	}
}
