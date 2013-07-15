using UnityEngine;
using System.Collections;

public class endSceneGUI : MonoBehaviour 
{
	
	public GUISkin mySkin;
	private Rect windowRect = new Rect((Screen.width - 300)/2, (Screen.height - 400)/2, 0, 0);
	public GUIStyle titleStyle;
	public GUIStyle bodyStyle;

	// Use this for initialization
	void Start () 
	{
		//DontDestroyOnLoad(gameObject);
		//Screen.SetResolution(1024, 768, true, 60);	
		print (Screen.width);
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

		GUILayout.BeginArea(new Rect((Screen.width -250)/2, (Screen.height - 80), 250,80));
		if(GUILayout.Button("Restart Simulation?", GUILayout.Width(250)))
		{
			Application.LoadLevelAsync(1);
		}
		if(GUILayout.Button("Select Scenario", GUILayout.Width(250)))
		{
			Application.LoadLevelAsync(2);
		}
		GUILayout.EndArea();
	}
	
	void popUp(int windowID) 
	{
		GUILayout.Label("Operation Statistics", titleStyle);	
		GUILayout.Space(30);
		GUILayout.Label("Total Time: " + MainGUI.niceTime, bodyStyle);
		//GUILayout.Space(30);
		GUILayout.Label("Length Examined: " + MainGUI.length + " cm", bodyStyle);
		GUILayout.Label("Lesions Discovered: " + MainGUI.lesions, bodyStyle);
		GUILayout.Label("Patient Discomfort Estimate (1-10): " + MainGUI.discomfortLevel, bodyStyle);
	}
}
