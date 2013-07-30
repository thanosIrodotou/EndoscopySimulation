using UnityEngine;
using System.Collections;

public class StatisticsGUI : MonoBehaviour 
{
	
	public GUISkin mySkin;
	private Rect windowRect = new Rect((Screen.width - 300)/2, (Screen.height - 400)/2, 0, 0);
	public GUIStyle titleStyle;
	public GUIStyle bodyStyle;
	public Vector2 scrollPosition;
	private string totalTime;
	private float totalLength;
	private int totalLesions;
	private float totalDiscomfort;

	// Use this for initialization
	void Start () 
	{
		//Screen.SetResolution(1920, 1080, true, 60);	
		//print (Screen.width);
		print ("Tr " + PlayerPrefs.GetFloat("TrLengthTraveled"));
		print ("Low " + PlayerPrefs.GetFloat("LowLengthTraveled"));
		print ("High " + PlayerPrefs.GetFloat("HighLengthTraveled"));
		totalLength = PlayerPrefs.GetFloat("TrLengthTraveled") + PlayerPrefs.GetFloat("LowLengthTraveled") + PlayerPrefs.GetFloat("HighLengthTraveled");
		totalLesions = PlayerPrefs.GetInt("TrLesions") + PlayerPrefs.GetInt("LowLesions") + PlayerPrefs.GetInt("HighLesions");
		totalDiscomfort = PlayerPrefs.GetFloat("TrDiscomfort") + PlayerPrefs.GetFloat("LowDiscomfort") + PlayerPrefs.GetFloat("HighDiscomfort");
		
		
		PlayerPrefs.SetString("AllDateTimeDataTaken", System.DateTime.Now.ToString());
		PlayerPrefs.SetString("AllTimeSpent", "Nil");
		PlayerPrefs.SetFloat("AllLength", totalLength);
		PlayerPrefs.SetInt("AllLesions", totalLesions);
		PlayerPrefs.SetFloat("AllDiscomfort", totalDiscomfort);
		PlayerPrefs.Save();

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
		if(GUILayout.Button("Back", GUILayout.Width(250)))
		{
			Application.LoadLevelAsync(0);
		}		
		
		GUILayout.EndArea();		
	}
	
	void popUp(int windowID) 
	{				
		if (PlayerPrefs.HasKey("AllDateTimeDataTaken"))
		{			
			GUILayout.Label("Statistics Summary", titleStyle);	
			GUILayout.Space(30);
			GUILayout.Label("Summary taken on: " + PlayerPrefs.GetString("AllDateTimeDataTaken"), bodyStyle);
			GUILayout.Space(5);
			GUILayout.Label("Total simulation duration: " + PlayerPrefs.GetString("AllTimeSpent"), bodyStyle);
			GUILayout.Space(5);
			GUILayout.Label("Total length examined: " + PlayerPrefs.GetFloat("AllLength") + " cm", bodyStyle);
			GUILayout.Space(5);
			GUILayout.Label("Total lesions discovered: " + PlayerPrefs.GetInt("AllLesions"), bodyStyle);
			GUILayout.Space(5);
			GUILayout.Label("Total discomfort caused (1-10): " + PlayerPrefs.GetFloat("AllDiscomfort"), bodyStyle);
		} 
		else 
		{
			GUILayout.Label("Overall Statistics", titleStyle);				
			GUILayout.Space(30);
			GUILayout.Label("No statistical information has been recorded yet.");
		}				
	}
}
