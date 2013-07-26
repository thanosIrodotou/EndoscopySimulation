using UnityEngine;
using System.Collections;

public class TrainingController : MonoBehaviour 
{

	private float startTime;
	private float ellapsedTime;
	public GUISkin mySkin;
	//private int spacing = 5;
	public static string niceTime;
	public static float length = 0f;
	public static int lesions;
	public static int discomfortLevel = 10;
	private Rect windowRect = new Rect((Screen.width - 260)/2, (Screen.height - 200)/2, 0, 0);
	public GUIStyle style;
	private bool hitEscape = false;
	private bool isTerminated = false;
	private bool pauseToggle = false;
	private bool escapePressed = false;
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
		lesions = 0;
		Screen.SetResolution(1920, 1080, true, 60);			
		mySkin = Resources.Load("Extra GUI Skins/MetalGUISkin") as GUISkin;
		sideCamTexture.enabled = false;
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
		//START OVERLAYS
		GUI.skin = mySkin;
		int minutes = Mathf.FloorToInt(ellapsedTime / 60F);
		int seconds = Mathf.FloorToInt(ellapsedTime - minutes * 60);
		niceTime = string.Format("{0:00}:{1:00}", minutes, seconds);	
		
		//OVERLAYS START
		GUILayout.BeginArea(new Rect((Screen.width -250)/2, 5, 300, 200));
		
		GUILayout.BeginHorizontal("box");
		GUILayout.Label("Time:");
		GUILayout.Box(niceTime);
		
		GUILayout.FlexibleSpace();
		//GUILayout.EndHorizontal();
		
		//GUILayout.BeginHorizontal("box");
		GUILayout.Label("Length Discovered:");
		GUILayout.Box(length.ToString() + " cm");
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
	
	public string GetElapsedTime
	{
		get { return niceTime; }
	}	
	
	void popUp(int windowID) 
	{
		GUILayout.Label("Are you sure you want to cancel the simulation?");
		if(GUILayout.Button("Yes", GUILayout.Width(280)))
		{
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