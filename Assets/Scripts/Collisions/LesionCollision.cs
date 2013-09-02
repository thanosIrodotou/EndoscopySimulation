using UnityEngine;
using System.Collections;

/**
 * The LesionCollision checks for collisions between lesions objects and the endoscopic unit.
 * It acts accordingly by enabling different lesions enforcing a pattern of lesions identification and collection based on the pre-designed Training scenario.
 * \author Athanasios Irodotou 2013
 */
public class LesionCollision : MonoBehaviour 
{
<<<<<<< HEAD
	public GameObject fpcObject; /**< A gameObject Editor variable to assign the FirstPersonController gameObject. */
	public GameObject ObstaclesSet; /**< A set of gameObjects assignable from the Editor to represent the lesions set. */
	private GameObject lesionTag; /**< A gameObject to represent each lesion tag object currently active. */
	private bool isLesion; /**< A boolean var to check if the obstacle is of lesion type. */
	private bool waterLesionCase = false; /**< A boolean to check if the current lesion belongs to the water disolvable lesion case. */
	public Texture waterTexture; /**< A Texture var to hold the water texture for water disolvable lesions. */
	public Texture normalTexture; /**< The normal texture of non-water disolvable lesions. */
	private bool nonLesionsCase = false; /**< This boolean var is true if the currently active gameObject is not a lesion. */
=======
	public GameObject fpcObject;
	public GameObject ObstaclesSet;
	private GameObject lesionTag;
	private bool isLesion;
	private string lesionObjectName;
	private bool success;
<<<<<<< HEAD
	private bool waterLesionCase = false;
	public Texture waterTexture;
	public Texture normalTexture;
	private float pauseTime = 0.0f;
=======
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
	
	// Use this for initialization
	void Start () 
	{		

	}
	
	
	// Update is called once per frame
	/**
	 * The Update method is another MonoBehaviour inherited method. The Update method is called every frame.
	 * This version of the update method checks for specific lesion names and cases and acts accordingly by sending a message to the TurnOnLesionsAndTags' TurnOnLesions() and TurnOnTags() methods to turn the necessary objects on/off.
	 * It also destroys lesions discovered and collected by the endoscopist.
	 */	
	void Update () 
	{
<<<<<<< HEAD
		print (gameObject.name);
=======
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
		if (gameObject.name == "ObstacleSphere2") 
		{
			waterLesionCase = true;
			renderer.material.mainTexture = waterTexture;
		}		
		else 
		{
			renderer.material.mainTexture = normalTexture;
		}	
		
<<<<<<< HEAD
		if (gameObject.name == "ObstacleSphere3" || gameObject.name == "StomachPause" || gameObject.name == "ObstacleSphere5" || gameObject.name == "ObstacleSphere6" || gameObject.name == "ObstacleSphere7")
		{
			nonLesionsCase = true;
		}
		
		if (gameObject.name == "StomachPause")
		{						
			if (Input.GetKeyDown(KeyCode.Space))
			{
=======
		if (gameObject.name == "StomachPause")
		{
			Time.timeScale = pauseTime;
			
			if (Input.GetKeyDown(KeyCode.Space))
			{
				pauseTime = 1.0f;
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
				lesionTag = GameObject.Find("LesionTag3");
				lesionTag.SendMessage("DestroyTag", true);
				lesionTag = GameObject.Find("LesionTag3.1");
				lesionTag.SendMessage("DestroyTag", true);
				lesionTag = GameObject.Find("LesionTag3.2");
				lesionTag.SendMessage("DestroyTag", true);
				ObstaclesSet.SendMessage("TurnOnLesions", 4);
			}
		}
	}
	
	
	/**
	 * A MonoBehaviour method that checks for collisions for object's whose colliders are marked as triggers.
	 * This method is called anytime a lesion object's mesh collider has collided with the FPC gameObject (i.e. the endoscope).
	 * It also indirectly increments the HUD's lesions discovered label when lesions are collected.
	 * \param myTrigger is the FPC object that has collided with a lesion gameObject.
	 */		
	void OnTriggerEnter(Collider myTrigger) 
	{		
		print ("wtf");
		if (myTrigger.gameObject.name == fpcObject.name)
<<<<<<< HEAD
		{
//			print ("sending...");
			if (!waterLesionCase)
			{
				TrainingController.sessionLesions = TrainingController.sessionLesions + 1;		
			}
			
			ActOnLesion(gameObject.name);						
		}
	}
	
	void ActOnLesion (string name)
	{
		if (name.Contains("ObstacleSphere1"))
		{					
			ObstaclesSet.SendMessage("TurnOnLesions", 1);
			ObstaclesSet.SendMessage("TurnOnTags", 1);
			lesionTag = GameObject.Find("LesionTag1");
			lesionTag.SendMessage("DestroyTag", true);			
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere3"))
		{
			ObstaclesSet.SendMessage("TurnOnTags", 2);
			ObstaclesSet.SendMessage("TurnOnTags", 3);
			ObstaclesSet.SendMessage("TurnOnTags", 4);	
			ObstaclesSet.SendMessage("TurnOnLesions", 3);
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere4"))
		{
			ObstaclesSet.SendMessage("TurnOnLesionsAndTheirTags", 4);
			//lesionTag = GameObject.Find("LesionTag2");
			//lesionTag.SendMessage("DestroyTag", true);
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere5"))
		{
			ObstaclesSet.SendMessage("TurnOnLesionsAndTheirTags", 5);
			//lesionTag = GameObject.Find("LesionTag2");
			//lesionTag.SendMessage("DestroyTag", true);
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere6"))
		{
			ObstaclesSet.SendMessage("TurnOnLesionsAndTheirTags", 6);
			//lesionTag = GameObject.Find("LesionTag2");
			//lesionTag.SendMessage("DestroyTag", true);
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere7"))
		{
=======
		{
			print ("sending...");
			if (!waterLesionCase && !nonLesionsCase)
			{
				TrainingController.sessionLesions = TrainingController.sessionLesions + 1;		
			}
			
			ActOnLesion(gameObject.name);						
		}
	}
	
	
	/**
	 * This method receives a lesion colliding gameObject's name and acts accordingly for each lesion case.
	 * Usually, it destroys the collided object and its tag, and turns on the next object and its tag.
	 * \param name is the current lesion gameObject's name which collided with the FPC.
	 */		
	void ActOnLesion (string name)
	{
		if (name.Contains("ObstacleSphere1"))
		{				
			print("ok");
			ObstaclesSet.SendMessage("TurnOnLesions", 1);
			ObstaclesSet.SendMessage("TurnOnTags", 1);
			lesionTag = GameObject.Find("LesionTag1");
			lesionTag.SendMessage("DestroyTag", true);			
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere3"))
		{
			ObstaclesSet.SendMessage("TurnOnTags", 2);
			ObstaclesSet.SendMessage("TurnOnTags", 3);
			ObstaclesSet.SendMessage("TurnOnTags", 4);	
			ObstaclesSet.SendMessage("TurnOnLesions", 3);
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere5"))
		{
			ObstaclesSet.SendMessage("TurnOnTags", 5);
			ObstaclesSet.SendMessage("TurnOnTags", 6);			
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere6"))
		{
<<<<<<< HEAD
			lesionTag = GameObject.Find("LesionTag4");
			lesionTag.SendMessage("DestroyTag", true);
			lesionTag = GameObject.Find("LesionTag5");
			lesionTag.SendMessage("DestroyTag", true);	
			ObstaclesSet.SendMessage("TurnOnTags", 7);
=======
			ObstaclesSet.SendMessage("TurnOnOffLesions", 6);
			//lesionTag = GameObject.Find("LesionTag2");
			//lesionTag.SendMessage("DestroyTag", true);
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere7"))
		{
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
			//lesionTag = GameObject.Find("LesionTag2");
			//lesionTag.SendMessage("DestroyTag", true);
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
			Destroy(gameObject);	
		}		
	}
}
