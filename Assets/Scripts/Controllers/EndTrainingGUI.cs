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
		GUILayout.Space(30);
		GUILayout.Label("Total Time: " + TrainingController.niceTime, bodyStyle);
		//GUILayout.Space(30);
		GUILayout.Label("Length Examined: " + TrainingController.length + " cm", bodyStyle);
		GUILayout.Label("Lesions Discovered: " + TrainingController.lesions, bodyStyle);
		GUILayout.Label("Patient Discomfort Estimate (1-10): " + TrainingController.discomfortLevel, bodyStyle);
	}
}
