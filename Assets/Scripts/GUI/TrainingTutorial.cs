using UnityEngine;
using System.Collections;

/**
 * This is the TrainingTutorial class. This class creates a set of instructive windows which teach users the basics of the simulation.
 * It also initialises and prepares all simulation elements, so that, when the user clicks "Finish" on the last tutorial page, the TrainingController class is readied and called.
 * \author Athanasios Irodotou 2013
 */

public class TrainingTutorial : MonoBehaviour 
{
<<<<<<< HEAD
	public GUISkin mySkin; /**< The mySkin variable is initialised in the Editor using a free, Unity provided set of GUI skins.  */
	public GUIStyle titleStyle; /**<  The style variable creates a new component in Unity's Editor which provides the ability to customise a variety of styling options for selected GUI elemements. Font type, size, color and other information are some of the styling options. This variable is used to set the title's text label style. */
	public GUIStyle bodyStyle; /**<  The style variable creates a new component in Unity's Editor which provides the ability to customise a variety of styling options for selected GUI elemements. Font type, size, color and other information are some of the styling options. This variable is used to set the body's text label style. */
	private Rect tipWindowRect = new Rect((Screen.width - 450)/2, (Screen.height - 450)/2, 450, 200); /**< Initialises the dimensions of a new Rect to display all pages of the Tutorial pop up menu. */
	private bool showTutWindow1; /**< A boolean value to check whether the first page of the Tutorial must be shown to the user. */
	private bool showTutWindow2 = false; /**< A boolean value to check whether the second Tutorial page must be shown. */
	private bool showTutWindow3 = false; /**< A boolean value to check whether the third Tutorial page must be shown. */
	private bool showTutWindow4 = false; /**< A boolean value to check whether the fourth Tutorial page must be shown. */
	public static bool showGUIOverlays; /**< A boolean variable to enable and disable the HUD display when the appropriate Tutorial page which explains them is presented. */
	public GameObject labelTagsToggle; /**< This variable creates a GameObject component selection in the Editor where the first label tag GUI text object can be attached. This way the script knows which objects, thus labels to turn on and off. */
	public GameObject obstacleObject; /**< A variable to hold another GameObject component. In this case it holds the equivalent lesion gameobject in oder to turn it on and off. */
	public Texture lesionImage; /**< A Texture type variable to store an image of the red flesh texture of lesions. It is used to a Tutorial page to portray the look of lesions to the user. */
	public Texture lesionImage2; /**< An additional Texture variable to store an image of the blue flesh texture of lesions. It is used to a Tutorial page to portray the look of lesions to the user. */
	public static bool didFinishTutorial; /**< A boolean variable to check if the user has gone through all of Tutorial's pages. */
	
=======
	public GUISkin mySkin;
	public GUIStyle titleStyle;
	public GUIStyle bodyStyle;
<<<<<<< HEAD
	private Rect tipWindowRect = new Rect((Screen.width - 450)/2, (Screen.height - 450)/2, 450, 200);
=======
	private Rect tipWindowRect = new Rect((Screen.width - 350)/2, (Screen.height - 400)/2, 350, 200);
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
	private bool showTutWindow1;
	private bool showTutWindow2 = false;
	private bool showTutWindow3 = false;
	private bool showTutWindow4 = false;
	private bool isTutShowing = true;
	private int startScenario = 0;
	public static bool showGUIOverlays;
	public GameObject labelTagsToggle;
<<<<<<< HEAD
	public GameObject obstacleObject;
=======
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
	public Texture lesionImage;
	public Texture lesionImage2;
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
	
	// Use this for initialization
	void Start () 
	{
<<<<<<< HEAD
		Time.timeScale = 0.0f;
=======
<<<<<<< HEAD
		Time.timeScale = 0.0f;
=======
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
		showTutWindow1 = true;
		showGUIOverlays = false;
		didFinishTutorial = false;
		GameObject.Find("FrontCam").GetComponent<RaycastCollision>().enabled = false;		
	}
	
	
	// Update is called once per frame
	void Update ()
	{
<<<<<<< HEAD
		
=======
<<<<<<< HEAD
		
=======
		Time.timeScale = startScenario;
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
	}
	
	
	/**
	 * Another MonoBehaviour inherited method loaded each frame to provide the necessary GUI drawcalls to check for GUI elements' changes and display them.
	 * This method provides all GUI elements, mostly buttons which lead to the rest scenes of the application.
	 * It basically draws all 4 windows represented as Tutorial pages, and initiliases the chosen GUI skin.
	 */		
	void OnGUI ()
	{		
		GUI.skin = mySkin;

		if (showTutWindow1)
		{
<<<<<<< HEAD
			tipWindowRect = GUILayout.Window(1, tipWindowRect, tipPopUp1, "Training Tutorial Introduction", GUILayout.Width(450), GUILayout.Height(390));	
=======
<<<<<<< HEAD
			tipWindowRect = GUILayout.Window(1, tipWindowRect, tipPopUp1, "Training Tutorial Introduction", GUILayout.Width(450), GUILayout.Height(390));	
		}	
		else if (showTutWindow2)
		{
			tipWindowRect = GUILayout.Window(1, tipWindowRect, tipPopUp2, "The GUI Elemens", GUILayout.Width(450), GUILayout.Height(390));
		}
		else if (showTutWindow3)
		{
			tipWindowRect = GUILayout.Window(1, tipWindowRect, tipPopUp3, "Dynamic Elements", GUILayout.Width(450), GUILayout.Height(390));
		}
		else if (showTutWindow4)
		{
			tipWindowRect = GUILayout.Window(1, tipWindowRect, tipPopUp4, "The Controls", GUILayout.Width(450), GUILayout.Height(380));
=======
			tipWindowRect = GUILayout.Window(1, tipWindowRect, tipPopUp1, "Training Tutorial Introduction", GUILayout.Width(350));	
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
		}	
		else if (showTutWindow2)
		{
			tipWindowRect = GUILayout.Window(1, tipWindowRect, tipPopUp2, "The GUI Elemens", GUILayout.Width(450), GUILayout.Height(390));
		}
		else if (showTutWindow3)
		{
			tipWindowRect = GUILayout.Window(1, tipWindowRect, tipPopUp3, "Dynamic Elements", GUILayout.Width(450), GUILayout.Height(390));
		}
		else if (showTutWindow4)
		{
<<<<<<< HEAD
			tipWindowRect = GUILayout.Window(1, tipWindowRect, tipPopUp4, "The Controls", GUILayout.Width(450), GUILayout.Height(380));
=======
			tipWindowRect = GUILayout.Window(1, tipWindowRect, tipPopUp4, "The Controls", GUILayout.Width(350));
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
		}
	}
	
	
	/**
	 * The tipPopUp1 method composites a popup window to provide the user with information on the first page of the Tutorial, which explains what the tutorial will cover and its importance.
	 * \param windowID a unique integer number for the window's id.
	 */		
	void tipPopUp1(int windowID)
	{		
		GUILayout.Space(5);
		
		GUILayout.Label(
			"Tutorial Section 1."
			+ "\n" + "\n" + "This scenario will take you through a series of steps." 
			+ "\n" + "Through these steps, you will learn how to navigate within the 3d human model." 
<<<<<<< HEAD
			+ "While navigating the human body you will be presented with challeneges you need to complete." 
			+ "\n" + "\n" + "These challenges will help you understand "
			+ "when to use the different modules of the endoscope," 
			+ "as well as emphasise on important sections of the human body," 
			+ "which are of particular interest in Upper Endoscopy."
			+ "\n" + "\n"  + "Click next when comfortable to begin."
=======
<<<<<<< HEAD
			+ "While navigating the human body you will be presented with challeneges you need to complete." 
			+ "\n" + "\n" + "These challenges will help you understand "
			+ "when to use the different modules of the endoscope," 
			+ "as well as emphasise on important sections of the human body," 
			+ "which are of particular interest in Upper Endoscopy."
			+ "\n" + "\n"  + "Click next when comfortable to begin."
=======
			+ "\n" + "While navigating the human body you will be presented with challeneges you need to complete." 
			+ "\n" + "These challenges will help you understand "
			+ "when to use the different modules of the endoscope," 
			+ "\n" + "as well as emphasise on important sections of the human body," 
			+ "\n" + "which are of particular interest in Upper Endoscopy."
			+ "\n"  + "Click next when comfortable to begin"
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
			, bodyStyle);	
		
		GUILayout.Space(10);			
		
		GUILayout.BeginHorizontal("");
<<<<<<< HEAD
		if(GUILayout.Button("Next"))
=======
<<<<<<< HEAD
		if(GUILayout.Button("Next"))
=======
		if(GUILayout.Button("Next", GUILayout.Width(350)))
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
		{
			showTutWindow1 = false;
			showTutWindow2 = true;
			showGUIOverlays = true;
			GameObject.Find("AllAxisUnlocked").guiTexture.enabled = true;
		}	
		GUILayout.EndHorizontal();
	}
	
	
	/**
	 * The tipPopUp2 method composites a popup window to provide the user with information on the second page of the Tutorial, which describes the HUD.
	 * \param windowID a unique integer number for the window's id.
	 */	
	void tipPopUp2(int windowID)
	{		
		GUILayout.Space(5);
		
		GUILayout.Label(
			"Tutorial Section 2"			
			+ "\n" + "\n" + "As you can see the simulation's HUD (located at the top center of the screen) is activated." 
			+ "\n" + "Your HUD shows essential information regarding the operation and how good or bad you are doing." 
			+ "\n" + "\n" + "Starting from left to right, you can check your elapsed time since the simulation was started, the length in cm, representing " +
				"how far you traveled since start, the number of lesions you identified and collected and finally Discomfort Level, an abstract value " +
				 "indicating the amount of pain your patient has suffered." 
			, bodyStyle);	
						
		GUILayout.Space(10);		
		
		GUILayout.BeginHorizontal("");
		if(GUILayout.Button("Back", GUILayout.Width(170)))
		{			
			showTutWindow2 = false;
			showTutWindow1 = true;		
		}
		
		GUILayout.FlexibleSpace();
		
		if(GUILayout.Button("Next", GUILayout.Width(170)))
		{			
			showTutWindow2 = false;
			showTutWindow3 = true;					
		}
		
		GUILayout.EndHorizontal();
	}

	
	/**
	 * The tipPopUp3 method composites a popup window to provide the user with information on the third page of the Tutorial, which describes the dynamic elements (lesions) he/she will encounter in the simulation.
	 * \param windowID a unique integer number for the window's id.
	 */	
	void tipPopUp3(int windowID)
	{		
		GUILayout.Space(5);
		
		GUILayout.Label(
			"Tutorial Section 3."			
			+ "\n" + "\n" + "Some elements will appear throughout " + "\n" +
				"the operation to simulate lesions " + "and/or " + "\n" +
				"areas of particular interest." 
			+ "\n" + "A type of lesion is shown on the right." 		
			
			+ "\n" + "\n" + "\n" + "Lesions can be identified and collected " + "\n" +
				"by pushing the endoscope towards them." 			
			+ "\n" + "Different kinds of lesions can be " + "\n" +
				"disolved by shooting water to them. " + "\n" +
				"An example of such " +	"lesions is presented " + "\n" +
<<<<<<< HEAD
				"on the right." 			
			, bodyStyle);			
		
		GUI.DrawTexture(new Rect(345, 82, 95, 100), lesionImage, ScaleMode.ScaleToFit, true, 0);
		GUI.DrawTexture(new Rect(345, 185, 95, 100), lesionImage2, ScaleMode.ScaleToFit, true, 0);
=======
<<<<<<< HEAD
				"on the right." 			
			, bodyStyle);			
		
		GUI.DrawTexture(new Rect(345, 82, 95, 100), lesionImage, ScaleMode.ScaleToFit, true, 0);
		GUI.DrawTexture(new Rect(345, 185, 95, 100), lesionImage2, ScaleMode.ScaleToFit, true, 0);
=======
				"on bottom right." 			
			, bodyStyle);
		
		GUILayout.Space(10);
		
		GUI.DrawTexture(new Rect(280, 82, 95, 100), lesionImage, ScaleMode.ScaleToFit, true, 0);
		GUI.DrawTexture(new Rect(280, 185, 95, 100), lesionImage2, ScaleMode.ScaleToFit, true, 0);
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
		
		GUILayout.Space(10);		
		
		GUILayout.BeginHorizontal("");
		if(GUILayout.Button("Back", GUILayout.Width(170)))
		{			
			showTutWindow3 = false;
			showTutWindow2 = true;		
		}
		
		GUILayout.FlexibleSpace();
		
		if(GUILayout.Button("Next", GUILayout.Width(170)))
		{			
			showTutWindow3 = false;
			showTutWindow4 = true;		
		}
		
		GUILayout.EndHorizontal();
	}
	
	
	/**
	 * The tipPopUp4 method composites a popup window to provide the user with the information on the fourth and final page of the Tutorial, which describes the keyboard and mouse controls.
	 * \param windowID a unique integer number for the window's id.
	 */	
	void tipPopUp4(int windowID)
	{		
		GUILayout.Space(5);
		
		GUILayout.Label(
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
			"Tutorial Section 4."	
			+ "\n" + "\n" + "Mouse Controls:"
			+ "\n" + "Simply move the mouse forward to push the endoscope inside the 3d model or backward to pull it." 
			+ "\n" + "Left and right mouse movements rotate the tip of the endoscope."
			
			+ "\n" + "\n" + "Keyboard Controls:"
			+ "\n" + "Pressing the 'shift' key will activate the water spray. You can use this functionality to clear obstacles throughout the simulation." 			
			+ "\n" + "To activate the endoscope's side camera view, press the 'space bar' on your keyboard. Side view might be useful to check specific areas " +
				"like the 'Ampulla of Vater'. Pressing the 'b' key will bring up another view called the Bird's Eye View. This view comes from a camera above the human organs, showing the endoscope's position and current position. You can lock the horizontal movement of the endoscope's tip by pressing 'control'. This way you can easily " +
				"take a biopsy using the biopsy needle or focus on an interesting area."		
<<<<<<< HEAD
			, bodyStyle);	
		
		GUILayout.Space(10);
				
=======
			, bodyStyle);	
		
		GUILayout.Space(10);
				
=======
			"Tutorial Section 4."			
			, bodyStyle);	
		
		GUILayout.Space(180);
		
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
		GUILayout.BeginHorizontal("");
		if(GUILayout.Button("Back", GUILayout.Width(170)))
		{			
			showTutWindow4 = false;
			showTutWindow3 = true;		
		}
		
		GUILayout.FlexibleSpace();
		
		if(GUILayout.Button("Finish", GUILayout.Width(170)))
		{			
			showTutWindow4 = false;
			GameObject.Find("FrontCam").GetComponent<BlurEffect>().enabled = false;		
<<<<<<< HEAD
			GameObject.Find("FrontCam").GetComponent<RaycastCollision>().enabled = true;
			obstacleObject.SetActive(true);
			
=======
<<<<<<< HEAD
			GameObject.Find("FrontCam").GetComponent<RaycastCollision>().enabled = true;
			obstacleObject.SetActive(true);
			
			labelTagsToggle.SetActive(true);
			showGUIOverlays = true;
			Time.timeScale = 1.0f;
		}
		
		GUILayout.EndHorizontal();		
=======
			GameObject.Find("FrontCam").GetComponent<RaycastCollision>().enabled = true;		
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
			labelTagsToggle.SetActive(true);
			showGUIOverlays = true;
			Time.timeScale = 1.0f;
			PlayerPrefs.SetInt("HasGoneThroughTutorial", 1);			
			didFinishTutorial = true;
		}
		
<<<<<<< HEAD
		GUILayout.EndHorizontal();		
=======
		GUILayout.EndHorizontal();
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
	}
}
