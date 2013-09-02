using UnityEngine;
using System.Collections;

/**
 * This is the controller for the TrainingController class.
 * \author Athanasios Irodotou 2013
 */
public class TrainingController : MonoBehaviour 
{

<<<<<<< HEAD
	private float startTime; /**< A float to store the startTime of the simulation. */
	private float ellapsedTime; /**< A float to store how much time has passed during the simulation. */
	public GUISkin mySkin; /**< The mySkin variable is initialised in the Editor using a free, Unity provided set of GUI skins. */
	public static string niceTime; /**< A string variable to convert the float time variable to string format. */
	public static float length; /**< The length is a float variable to store the current endoscope's length. It stores the overall length traveled in all Training sessions. */
	public static float sessionLength = 0f; /**< A float to store the current endoscope's length for the session. */
	public static int lesions; /**< A integer variable to store the number of lesions collected. Again this is the sum of all lesions identified in all Training sessions. */
	public static int sessionLesions = 0; /**< sessionLesions is used to stored the collected lesions for the session. */
	public static float discomfortLevel; /**< discomfortLevel is storing the sum of discomfort caused in all Training sessions. */
	public static float sessionDiscomfortLevel; /**< A float variable that stores the session's discomfort level. */
	private Rect windowRect = new Rect((Screen.width - 260)/2, (Screen.height - 200)/2, 0, 0); /**< Initialises the dimensions of a new Rect to display the scenario's termination dialog. */
	public GUIStyle style; /**<  The style variable creates a new component in Unity's Editor which provides the ability to customise a variety of styling options for selected GUI elemements. */
	public static bool hitEscape = false; /**< A boolean to check if the "escape" keyboard key was pressed. */
	private bool isTerminated = false; /**< True if the user ends the simulation scenario. */
	private bool pauseToggle = false; /**< If the user presses the "escape" keyboard key, the simulation is paused and this is true. */
	public bool sideCamToggle = false; /**< True if the "space" keyboard key was pressed. */
	public bool birdsEyeToggle = false; /**< True if the "b" keyboard key was pressed. */
	public GUITexture sideCamTexture; /**< A GUITexture variable that stores the sideCam's render texture. */
	public GUITexture birdsEyeTexture; /**< A GUITexture variable that stores the bird'sEyeCam's render texture. */	
	private bool isVerticallyStabilised = false; /**< A bool to check if the endoscope is vertically stabilised. */
	private bool isHorizontallyStabilised = false; /**< A bool to check if the endoscope is horizontally stabilised. */
	public static bool areAllAxisStabilised = false; /**< A bool to check if the endoscope is totally stabilised. */
	private float camFOV; /**< A float to set the main camera's FOV to a new value based on a slider's position. */
=======
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
<<<<<<< HEAD
	public bool birdsEyeToggle = false;
	public GUITexture sideCamTexture;	
	public GUITexture birdsEyeTexture;	
	private bool isVerticallyStabilised = false;
	private bool isHorizontallyStabilised = false;
	public static bool areAllAxisStabilised = false;
=======
	public GUITexture sideCamTexture;	
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9

	void Awake() 
	{	
		//startTime = Time.time;				
	}
	
	
	// Use this for initialization
	void Start () 
<<<<<<< HEAD
	{					
=======
<<<<<<< HEAD
	{					
=======
	{		
		Time.timeScale = 1;		
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
		startTime = Time.time;
		sessionLength = 0f;
		sessionLesions = 0;
		sessionDiscomfortLevel = 0f;
		Screen.SetResolution(1920, 1080, true, 60);			
		mySkin = Resources.Load("Extra GUI Skins/MetalGUISkin") as GUISkin;
		sideCamTexture.enabled = false;
		birdsEyeTexture.enabled = false;	
		length = PlayerPrefs.GetFloat("TrLengthTraveled");
		lesions = PlayerPrefs.GetInt("TrLesions");
		discomfortLevel = PlayerPrefs.GetFloat("TrDiscomfort");
		camFOV = camera.fieldOfView;
			
	}
	
		
	// Update is called once per frame
	/**
	 * The Update method is another MonoBehaviour inherited method. The Update method is called every frame.
	 * It initialises the timer, and calls the InputManager() method to check for user input and act accordingly.
	 * This method also loads the next scene if this scenario is terminated by the user.
	 * Additionally, it changes the endoscope's camera FOV value in realtime based on slider input.
	 */	
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
		
		if ( !Mathf.Approximately ( camFOV, camera.fieldOfView)) 
			camera.fieldOfView = camFOV;	
		
		InputManager();
					
	}
	
	
	/**
	 * The InputManager() checks for user input and acts accordingly.
	 * This method acts on a collection of keyboard inputs to perform actions like showing the sideCam and bird's eye views, limiting the endoscope's horizontal and forward movement, etc.
	 */		
	void InputManager()
	{
		if (Input.GetKeyDown(KeyCode.Escape) && TrainingTutorial.didFinishTutorial == true)
		{	
			gameObject.GetComponent<MouseLook>().enabled = false;
			hitEscape = true;
			pauseToggle = true;
			if(pauseToggle)
<<<<<<< HEAD
			Time.timeScale = 0.0f;			
=======
<<<<<<< HEAD
			Time.timeScale = 0;			
=======
			Time.timeScale = 0;
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
		}	
	
		if (Input.GetKeyDown(KeyCode.Space)  || Input.GetButtonDown("SideCam"))
		{
			if (sideCamToggle == false)
			{
				sideCamToggle = true;
				sideCamTexture.enabled = true;			
			}
			else if (sideCamToggle == true)
			{
				sideCamToggle = false;
				sideCamTexture.enabled = false;
			}
		}
		
		if (Input.GetKeyDown(KeyCode.B)  || Input.GetButtonDown("BirdsEyeCam"))
		{
			if (birdsEyeToggle == false)
			{
				birdsEyeToggle = true;
				birdsEyeTexture.enabled = true;
			}
			else if (birdsEyeToggle == true)
			{
				birdsEyeToggle = false;
				birdsEyeTexture.enabled = false;
			}
		}
		
		if (isVerticallyStabilised == false && Input.GetKeyDown(KeyCode.LeftControl))
		{
<<<<<<< HEAD
			GameObject.Find("First Person Controller").GetComponent<MouseLook>().enabled = false;			
			isVerticallyStabilised = true;		
			GameObject.Find("AllAxisUnlocked").guiTexture.enabled = false;
			GameObject.Find("HorizontalLock").guiTexture.enabled = true;
		}		
		else if (isVerticallyStabilised == true && !isHorizontallyStabilised == true && Input.GetKeyDown(KeyCode.LeftControl))
		{		
			GameObject.Find("First Person Controller").SendMessage("DisableCharacterMotor", false);
			isHorizontallyStabilised = true;
			GameObject.Find("HorizontalLock").guiTexture.enabled = false;
			GameObject.Find("AllAxisLocked").guiTexture.enabled = true;
=======
			GameObject.Find("First Person Controller").GetComponent<MouseLook>().enabled = false;
			isVerticallyStabilised = true;
		}		
		else if (isVerticallyStabilised == true && !isHorizontallyStabilised == true && Input.GetKeyDown(KeyCode.LeftControl))
		{
			//gameObject.GetComponent("MouseLook").enabled = !GetComponent("MouseLook").enabled;			
			GameObject.Find("First Person Controller").SendMessage("DisableCharacterMotor", false);
			isHorizontallyStabilised = true;
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
			areAllAxisStabilised = true;
		}
		else if (areAllAxisStabilised == true && Input.GetKeyDown(KeyCode.LeftControl))
		{
<<<<<<< HEAD
			GameObject.Find("First Person Controller").GetComponent<MouseLook>().enabled = true;
			GameObject.Find("First Person Controller").SendMessage("DisableCharacterMotor", true);
			areAllAxisStabilised = false;
			GameObject.Find("AllAxisLocked").guiTexture.enabled = false;
			GameObject.Find("AllAxisUnlocked").guiTexture.enabled = true;
			isHorizontallyStabilised = false;
			isVerticallyStabilised = false;
		}		
=======
			print ("i'm in");
			GameObject.Find("First Person Controller").GetComponent<MouseLook>().enabled = true;
			GameObject.Find("First Person Controller").SendMessage("DisableCharacterMotor", true);
			areAllAxisStabilised = false;
			isHorizontallyStabilised = false;
			isVerticallyStabilised = false;
		}
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
	}
	
	void OnTriggerEnter()
	{
		startTime = Time.time;
	}
	
	void OnTriggerExit()
	{
		startTime = 0;
	}
	
	
	/**
	 * Another MonoBehaviour inherited method loaded each frame to provide the necessary GUI drawcalls to check for GUI elements' changes and display them.
	 * This method provides all GUI elements. It draws the HUD. It also checks if "escape" was hit to show the exit pop up window calling the popUp() method.
	 */	
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
<<<<<<< HEAD
			GUILayout.Box(sessionDiscomfortLevel.ToString("F2"));		
			
			GUILayout.FlexibleSpace();
			
			GUILayout.Label("FOV: ");
			GUILayout.Box(camera.fieldOfView.ToString("F0"));	
=======
<<<<<<< HEAD
			GUILayout.Box(sessionDiscomfortLevel.ToString("F2"));		
=======
			GUILayout.Box(sessionDiscomfortLevel.ToString());		
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
			
			camFOV = GUILayout.VerticalSlider( camFOV, 40, 80, GUILayout.Height(40) );				
				
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

	
	/**
	 * This popUp method creates a new popup window. The user clicks yes to terminate the current scenario or no to continue.
	 * \param windowID a unique integer number for the window's id.
	 */	
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
			Time.timeScale = 1.0f;	
		}
	}
}