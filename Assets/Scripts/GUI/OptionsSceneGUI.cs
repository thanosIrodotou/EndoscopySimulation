<<<<<<< HEAD
using UnityEngine;
using System.Collections;

/**
 * This class provides the user the options to reset the statistics collected by the app and toggle the dynamic elemens (i.e. lesions) on and off.
 * \author Athanasios Irodotou 2013
 */

public class OptionsSceneGUI : MonoBehaviour 
{
	private int spacing = 10; /**< How much vertical space separates the GUI elements. */
	public GUISkin mySkin; /**< The mySkin variable is initialised in the Editor using a free, Unity provided set of GUI skins.  */
	private bool togglePopUp = false; /**< A boolean variable to check if the reset statistics confirmation popup is showing. */
	private Rect windowRect = new Rect((Screen.width - 300)/2, (Screen.height - 500)/2, 0, 0); /**< Initialises the dimensions of a new Rect to display the reset statistics confirmation pop menu. */
	private bool deactivateResetButton = false; /**< A boolean variable used to check if the reset button is currently enabled or disabled. */
	public static bool enableDynamicSimElements = false; /**< A boolean variable that stores true or false depending on whether the user has enabled or disabled the dynamic elements in the two simulation scenarios. */
	
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{

	}
	
	IEnumerator ShowPopUp() 
	{
		togglePopUp = true;
		deactivateResetButton = true;
		yield return new WaitForSeconds(2);
		togglePopUp = false;
		deactivateResetButton = false;
	}	

	/**
	 * Another MonoBehaviour inherited method loaded each frame to provide the necessary GUI drawcalls to check for GUI elements' changes and display them.
	 * This method provides all GUI elements, the two buttons for reseting statistics and toggling on/off dynamic elements and a third back to main menu button .
	 */		
	void OnGUI () 
	{
		GUI.skin = mySkin;			
		
		if (togglePopUp)
		{			
			windowRect = GUILayout.Window(0, windowRect, resetConfirmationPopUp, "Reset Confirmation", GUILayout.Width(300), GUILayout.Height(105));			
		}

		GUILayout.BeginArea(new Rect((Screen.width - 250)/2, (Screen.height - 250)/2, 250, 250));	
		
		GUILayout.Space(spacing);		
		
		if (deactivateResetButton == false)
		{
			if(GUILayout.Button("Reset Statistics!", GUILayout.Width(250)))
			{
				StartCoroutine(ShowPopUp());
				PlayerPrefs.DeleteAll();
			}				
		}
		
		GUILayout.Space(spacing);	
		
		if (PlayerPrefs.GetInt("DynamicElementsState") == 1)
		{
			if(GUILayout.Button("Disable Dynamic Elements" + "\n" + " (in Simulation Scenarios.", GUILayout.Width(250)))
			{
				enableDynamicSimElements = false;
				PlayerPrefs.SetInt("DynamicElementsState", 0);
			}	
		}
		else if (PlayerPrefs.GetInt("DynamicElementsState") == 0)
		{
			if(GUILayout.Button("Enable Dynamic Elements" + "\n" + " (in Simulation Scenarios.", GUILayout.Width(250)))
			{
				enableDynamicSimElements = true;	
				PlayerPrefs.SetInt("DynamicElementsState", 1);
			}
		}

						
		
		
		GUILayout.Space(spacing);
		
		if(GUILayout.Button("Back", GUILayout.Width(250)))
		{
			Application.LoadLevelAsync(0);
		}		
		
		GUILayout.EndArea();
	}
	
	/**
	 * This method is called if the reset statistics button is pressed, and displays a popup window which informs the user that all recorded data is deleted.
	 * \param windowID a unique integer number for the window's id. 
	 */	
	void resetConfirmationPopUp(int windowID) 
	{
			GUILayout.Label("All Statistics have been successfully erased.");			
	}	
}
=======
using UnityEngine;
using System.Collections;

public class OptionsSceneGUI : MonoBehaviour 
{
	private int spacing = 10;
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
		
		if(GUILayout.Button("Reset Statistics!", GUILayout.Width(250)))
		{
			PlayerPrefs.DeleteAll();
		}
		
		GUILayout.Space(spacing);
		
		if(GUILayout.Button("Back", GUILayout.Width(250)))
		{
			Application.LoadLevelAsync(0);
		}		
		
		GUILayout.EndArea();
	}
}
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
