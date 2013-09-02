<<<<<<< HEAD
using UnityEngine;
using System.Collections;

/**
 * The CreditsSceneGUI class simply gives credit to all sources.
 * \author Athanasios Irodotou 2013
 */

public class CreditsSceneGUI : MonoBehaviour 
{	
	public GUISkin mySkin; /**< The mySkin variable is initialised in the Editor using a free, Unity provided set of GUI skins.  */
	public GUIStyle style; /**<  The style variable creates a new component in Unity's Editor which provides the ability to customise a variety of styling options for selected GUI elemements. Font type, size, color and other information are some of the styling options. */

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	/**
	 * A MonoBehaviour method which is inherited and called every frame to create the necessary labels and buttons for the credits section.	 
	 */	
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
=======
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
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
