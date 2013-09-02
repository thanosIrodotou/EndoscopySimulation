<<<<<<< HEAD
using UnityEngine;
using System.Collections;

/**
 * This class checks for collisions between the FPC gameObject and the StartCube gameObject.
 * Upon sucessful collision, the LimitPosition.cs script is called to limit the endoscope's starting position.
 * \author Athanasios Irodotou 2013
 */
public class LimitStartPositionCollision : MonoBehaviour 
{
	public GameObject fpsObject; /**< A reference to the FPC gameObject. */

	// Use this for initialization
	void Start () 
	{		

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	
	/**
	 * A MonoBehaviour method that checks for collisions for object's whose colliders are marked as triggers.
	 * This method is called anytime the FPC object collides with the StartCube gameObject.
	 * It creates an instance of the LimitPosition script and calls its limitStartingPosition() method.
	 * \param myTrigger is the FPC object that has collided with the StartCube gameObject.
	 */		
	void OnTriggerEnter(Collider myTrigger) 
	{
		if (myTrigger.gameObject.name == fpsObject.name)
		{
			print ("sending...");	
			LimitPosition script;
			script = myTrigger.GetComponent<LimitPosition>();				
			script.startPosLimitToggle = true;
			script.limitStartingPosition(true);			
		}
	}
}
=======
using UnityEngine;
using System.Collections;

public class LimitStartPositionCollision : MonoBehaviour 
{
	public GameObject fpsObject;

	// Use this for initialization
	void Start () 
	{		

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnTriggerEnter(Collider myTrigger) 
	{
		if (myTrigger.gameObject.name == fpsObject.name)
		{
			print ("sending...");	
			LimitPosition script;
			script = myTrigger.GetComponent<LimitPosition>();				
			script.startPosLimitToggle = true;
			script.limitStartingPosition(true);			
		}
	}
}
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
