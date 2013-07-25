using UnityEngine;
using System.Collections;

public class StatisticsGUI : MonoBehaviour 
{
	
	public GUISkin mySkin;
	private Rect windowRect = new Rect((Screen.width - 300)/2, (Screen.height - 400)/2, 0, 0);
	public GUIStyle titleStyle;
	public GUIStyle bodyStyle;
	private float wPos = (Screen.width - 300)/2f;
	private float hPos = (Screen.height - 400)/2f;
	public Vector2 scrollPosition;

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
		
		//scrollPosition = GUILayout.BeginScrollView(scrollPosition, GUILayout.Width(300), GUILayout.Height(250));			
//			if (PlayerPrefs.HasKey("TimeSpent"))
//			{			
//				GUILayout.Label("Overall Statistics", titleStyle);	
//				GUILayout.Space(30);
//				GUILayout.Label("Data taken on: " + PlayerPrefs.GetString("DateTimeDataTaken"), bodyStyle);
//				GUILayout.Space(5);
//				GUILayout.Label("Simulation duration: " + PlayerPrefs.GetString("TimeSpent"), bodyStyle);
//				GUILayout.Space(5);
//				GUILayout.Label("Length examined: " + TrainingController.length + " cm", bodyStyle);
//				GUILayout.Space(5);
//				GUILayout.Label("Lesions discovered: " + TrainingController.lesions, bodyStyle);
//				GUILayout.Space(5);
//				GUILayout.Label("Patient discomfort Estimate (1-10): " + TrainingController.discomfortLevel, bodyStyle);
//			}
//		GUILayout.EndScrollView();
		
		windowRect = GUILayout.Window(0, windowRect, popUp, "", GUILayout.Width(300), GUILayout.Height(250));				 		
		
		GUILayout.BeginArea(new Rect((Screen.width -250)/2, (Screen.height + 150)/2, 250,250));
		if(GUILayout.Button("Back", GUILayout.Width(250)))
		{
			Application.LoadLevelAsync(0);
		}		
		
		GUILayout.EndArea();
		
	}
	
	void popUp(int windowID) 
	{
		
		if (PlayerPrefs.HasKey("TimeSpent"))
		{			
			GUILayout.Label("Overall Statistics", titleStyle);	
			GUILayout.Space(30);
			GUILayout.Label("Data taken on: " + PlayerPrefs.GetString("DateTimeDataTaken"), bodyStyle);
			GUILayout.Space(5);
			GUILayout.Label("Simulation duration: " + PlayerPrefs.GetString("TimeSpent"), bodyStyle);
			GUILayout.Space(5);
			GUILayout.Label("Length examined: " + TrainingController.length + " cm", bodyStyle);
			GUILayout.Space(5);
			GUILayout.Label("Lesions discovered: " + TrainingController.lesions, bodyStyle);
			GUILayout.Space(5);
			GUILayout.Label("Patient discomfort Estimate (1-10): " + TrainingController.discomfortLevel, bodyStyle);
		} 
		else 
		{
			GUILayout.Label("Overall Statistics", titleStyle);				
			GUILayout.Space(30);
			GUILayout.Label("No statistical information has been recorded yet.");
		}
					
	}
}
