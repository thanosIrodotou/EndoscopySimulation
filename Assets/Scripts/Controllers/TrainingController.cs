using UnityEngine;
using System.Collections;

public class TrainingController : MonoBehaviour 
{

	private float startTime;
	private float ellapsedTime;
	public GUISkin mySkin;
	//private int spacing = 5;
	public static string niceTime;
	public static float length;
	public static float sessionLength = 0f;
	public static int lesions;
	public static int sessionLesions = 0;	
	public static float discomfortLevel;
	public static float sessionDiscomfortLevel;
	private Rect windowRect = new Rect((Screen.width - 260)/2, (Screen.height - 200)/2, 0, 0);
	public GUIStyle style;
	private bool hitEscape = false;
	private bool isTerminated = false;
	private bool pauseToggle = false;
	public bool sideCamToggle = false;	
	public GUITexture sideCamTexture;	

	void Awake() 
	{	
		//startTime = Time.time;				
	}
	
	// Use this for initialization
	void Start () 
	{		
		Time.timeScale = 1;		
		startTime = Time.time;
		sessionLength = 0f;
		sessionLesions = 0;
		sessionDiscomfortLevel = 0f;
		Screen.SetResolution(1920, 1080, true, 60);			
		mySkin = Resources.Load("Extra GUI Skins/MetalGUISkin") as GUISkin;
		sideCamTexture.enabled = false;
		length = PlayerPrefs.GetFloat("TrLengthTraveled");
		lesions = PlayerPrefs.GetInt("TrLesions");
		discomfortLevel = PlayerPrefs.GetFloat("TrDiscomfort");
	}

	// Update is called once per frame
	void Update () 
	{		
		if (startTime > 0)
		{
			ellapsedTime = Time.time - startTime;
		}	
	
		if (isTerminated == true)
		{
			Application.LoadLevel(7);
		}
		
		if (Input.GetKeyDown(KeyCode.Escape))
		{	
			gameObject.GetComponent<MouseLook>().enabled = false;
			hitEscape = true;
			pauseToggle = true;
			if(pauseToggle)
			Time.timeScale = 0;
		}	
	
		if (Input.GetKeyDown(KeyCode.Space)  || Input.GetButtonDown("SideCam"))
		{
			print ("Space Pressed");
			if (sideCamToggle == false)
			{
				sideCamToggle = true;
				sideCamTexture.enabled = true;
				
				print ("sideCam On");
			}
			else if (sideCamToggle == true)
			{
				sideCamToggle = false;
				sideCamTexture.enabled = false;
				print ("sideCam Off");
			}
		}	
	}
	
	void OnTriggerEnter()
	{
		startTime = Time.time;
	}
	
	void OnTriggerExit()
	{
		startTime = 0;
	}
	
	void OnGUI ()
	{
		if (TrainingTutorial.showGUIOverlays)
		{
			//START OVERLAYS
			GUI.skin = mySkin;
			int minutes = Mathf.FloorToInt(ellapsedTime / 60F);
			int seconds = Mathf.FloorToInt(ellapsedTime - minutes * 60);
			niceTime = string.Format("{0:00}:{1:00}", minutes, seconds);	
			
			//OVERLAYS START
			GUILayout.BeginArea(new Rect((Screen.width - 600)/2, 5, 600, 200));
			
			GUILayout.BeginHorizontal("box");
			GUILayout.Label("Time:");
			GUILayout.Box(niceTime);
			
			GUILayout.FlexibleSpace();
			//GUILayout.EndHorizontal();
			
			//GUILayout.BeginHorizontal("box");
			GUILayout.Label("Length Discovered:");
			GUILayout.Box(sessionLength.ToString() + " cm");
			
			GUILayout.FlexibleSpace();
			
			GUILayout.Label("Lesions Discovered:");
			GUILayout.Box(sessionLesions.ToString());
			
			GUILayout.FlexibleSpace();
			
			GUILayout.Label("Discomfort Level:");
			GUILayout.Box(sessionDiscomfortLevel.ToString());		
			
			GUILayout.EndHorizontal();
			
			GUILayout.EndArea();
			//END OVERLAYS
		
			//START BUTTONS	
			if (hitEscape == true)
			{
				windowRect = GUILayout.Window(0, windowRect, popUp, "", GUILayout.Height(100), GUILayout.Width(100));	
			}	
			//END BUTTONS
		}			
	}	
	
	public string GetElapsedTime
	{
		get { return niceTime; }
	}	
	
	void popUp(int windowID) 
	{
		GUILayout.Label("Are you sure you want to cancel the training?");
		if(GUILayout.Button("Yes", GUILayout.Width(280)))
		{
			discomfortLevel += sessionDiscomfortLevel;	
			length += sessionLength;
			lesions += sessionLesions;
			PlayerPrefs.SetString("TrDateTimeDataTaken", System.DateTime.Now.ToString());
			PlayerPrefs.SetString("TrCurrentSimScenario", "'Training'");							
			PlayerPrefs.SetString("TrTimeSpent", niceTime);	
			PlayerPrefs.SetFloat("TrLengthTraveled", length);
			PlayerPrefs.SetFloat("TrSessionLengthTraveled", sessionLength);
			PlayerPrefs.SetInt("TrLesions", lesions);
			PlayerPrefs.SetInt("TrSessionLesions", sessionLesions);
			PlayerPrefs.SetFloat("TrDiscomfort", discomfortLevel);
			PlayerPrefs.SetFloat("TrSessionDiscomfort", sessionDiscomfortLevel);			
			PlayerPrefs.Save();
			isTerminated = true;
		}
		if(GUILayout.Button("No", GUILayout.Width(280)))
		{
			isTerminated = false;
			hitEscape = false;
			pauseToggle = false;
			Time.timeScale = 1;	
		}
	}
}