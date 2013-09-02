using UnityEngine;
using System.Collections;

/**
 * The StatisticsGUI class retrieves and displays in a summary all statistics recorded when the simulation is runing.
 * This functionality provides a description of user's action which can be refrenced to help users improve their skills in using the simulation.
 * \author Athanasios Irodotou 2013
 */

public class StatisticsGUI : MonoBehaviour 
{
	
	public GUISkin mySkin; /**< The mySkin variable is initialised in the Editor using a free, Unity provided set of GUI skins.  */
	private Rect windowRect = new Rect((Screen.width - 300)/2, (Screen.height - 400)/2, 0, 0);
	public GUIStyle titleStyle; /**<  The style variable creates a new component in Unity's Editor which provides the ability to customise a variety of styling options for selected GUI elemements. Font type, size, color and other information are some of the styling options. This variable is used to set the title's text label style. */
	public GUIStyle bodyStyle; /**<  The style variable creates a new component in Unity's Editor which provides the ability to customise a variety of styling options for selected GUI elemements. Font type, size, color and other information are some of the styling options. This variable is used to set the body's text label style. */
	private string totalStringTime; /**< A string variable to store the total elapsed time in String format. This value represents the sum of time spent in all three scenarios. */
	private float totalLength; /**< A float variable to store the total length the endoscope has traveled. This value represents sum of length traveled in all three scenarios. */
	private int totalLesions; /**< An Integer variable to store the total number of lesions descovered and collected by the user. This value represents the sum of lesions identified in all scenarios. */
	private float totalDiscomfort; /**< A float variable to store the total discomfort value caused to the patient. This value represents the sum of discomfort caused in all three scenarios. */
	private float totalFloatTime; /**< A float variable to store the total elapsed time in Float format. This value represents the sum of time spent in all three scenarios. */

	// Use this for initialization
	/**
	 * The Start method is a MonoBehaviour inherited method called once when the scene which is included in is first loaded. 
	 * This method makes sure all required variables are initialised and are ready when the scene needs them.
	 * In this case, the start method retrieves all saved game statistics recorded when the simulation last run, it then saves this information to the variables described above and uses that data to fill in the GUI elements in the statistics window.
	 */	
	void Start () 
	{
<<<<<<< HEAD
		print (PlayerPrefs.GetFloat("HighTotalFloatTime"));
		totalFloatTime = PlayerPrefs.GetFloat("LowTotalFLoatTime") + PlayerPrefs.GetFloat("HighTotalFLoatTime");		
		totalLength = PlayerPrefs.GetFloat("TrLengthTraveled") + PlayerPrefs.GetFloat("LowLengthTraveled") + PlayerPrefs.GetFloat("HighLengthTraveled");
		totalLesions = PlayerPrefs.GetInt("TrLesions") + PlayerPrefs.GetInt("LowLesions") + PlayerPrefs.GetInt("HighLesions");
		totalDiscomfort = PlayerPrefs.GetFloat("TrDiscomfort") + PlayerPrefs.GetFloat("LowDiscomfort") + PlayerPrefs.GetFloat("HighDiscomfort");
		
		int minutes = Mathf.FloorToInt(totalFloatTime / 60F);
		int seconds = Mathf.FloorToInt(totalFloatTime - minutes * 60);
		totalStringTime = string.Format("{0:00}:{1:00}", minutes, seconds);
=======
		totalLength = PlayerPrefs.GetFloat("TrLengthTraveled") + PlayerPrefs.GetFloat("LowLengthTraveled") + PlayerPrefs.GetFloat("HighLengthTraveled");
		totalLesions = PlayerPrefs.GetInt("TrLesions") + PlayerPrefs.GetInt("LowLesions") + PlayerPrefs.GetInt("HighLesions");
		totalDiscomfort = PlayerPrefs.GetFloat("TrDiscomfort") + PlayerPrefs.GetFloat("LowDiscomfort") + PlayerPrefs.GetFloat("HighDiscomfort");
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
				
		PlayerPrefs.SetString("AllDateTimeDataTaken", System.DateTime.Now.ToString());
		PlayerPrefs.SetString("AllTimeSpent", totalStringTime);
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
	
	/**
	 * Another MonoBehaviour inherited method loaded each frame to provide the necessary GUI drawcalls to check for GUI elements' changes and display them.
	 * In this class this method creates a new box to present the summary of statistics collected by the application.
	 * A back button is also drawn to let the user go back to the main menu.
	 */		
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
	
	/**
	 * This method composites a popup window to display a summary of all collected statistics.
	 * \param windowID a unique integer number for the window's id.
	 */		
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
			GUILayout.Label("Total discomfort caused (1-10): " + PlayerPrefs.GetFloat("AllDiscomfort").ToString("F2"), bodyStyle);
		} 
		else 
		{
			GUILayout.Label("Overall Statistics", titleStyle);				
			GUILayout.Space(30);
			GUILayout.Label("No statistical information has been recorded yet.");
		}				
	}
}
