<<<<<<< HEAD
using UnityEngine;
using System.Collections;

/**
 * LimitPosition class. It checks for the endoscope's position when the endoscope has collided with the StartCube or the EndCube objects. 
 * These object's are placed at the start and end positions of the endoscope inside the human body. This way the endoscope cannot get out of the patient (StartCube) or go further past the first section of the duodenum (EndCube).
 * \author Athanasios Irodotou 2013
 */
public class LimitPosition : MonoBehaviour 
{	 
	public bool startPosLimitToggle = false; /**< A boolean which is set to true when the endoscope collide's with the StartCube gameobject. */
	public bool endPosLimitToggle = false; /**< A boolean which is set to true when the endoscope collide's with the EndCube gameobject. */
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	
	//Get message from collider and handle object's position
	/**
	 * This method is called if the endoscope collide's with the StartCube gameobject to limit the endoscope's starting position inside the patient's mout.
	 * \param limitToggle a boolean value that is true when collision between the Endoscope and the StartCube gameobject is true.
	 */		
	public void limitStartingPosition (bool limitToggle)
	{
		if (startPosLimitToggle)
		{
			gameObject.transform.position = new Vector3(1.604631f, 0.5262575f, -0.5985594f);				
		}
	}	
	
	
	/**
	 * This method is called if the endoscope collide's with the StartCube gameobject to limit the endoscope's starting position inside the patient's first section of the duodenum.
	 * \param limitToggle a boolean value that is true when collision between the Endoscope and the EndCube gameobject is true.
	 */		
	public void limitEndingPosition (bool limitToggle)
	{
		if (endPosLimitToggle)
		{
			if (Application.loadedLevelName != "trainingScene")
				gameObject.transform.position = new Vector3(-0.6277301f, 0.5567473f, -0.2144468f);
			else
				gameObject.transform.position = new Vector3(-0.60967f, 0.558362f, -0.1060082f);
		}
	}
}
=======
using UnityEngine;
using System.Collections;

public class LimitPosition : MonoBehaviour 
{
	
	public Vector3 endoscopePosition;

	public bool startPosLimitToggle = false;
	public bool endPosLimitToggle = false;
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	//Get message from collider and handle object's position
	public void limitStartingPosition (bool limitToggle)
	{
		if (startPosLimitToggle)
		{
			print ("got it");
			gameObject.transform.position = new Vector3(1.604631f, 0.5262575f, -0.5985594f);				
		}
	}	
	
	public void limitEndingPosition (bool limitToggle)
	{
		if (endPosLimitToggle)
		{
			print ("got it");
			gameObject.transform.position = new Vector3(-0.620811f, 0.5555466f, 0.01f);
		}
	}
}
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
