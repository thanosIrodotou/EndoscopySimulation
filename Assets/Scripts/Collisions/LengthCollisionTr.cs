using UnityEngine;
using System.Collections;

/**
 * This class checks for collision with invisible trigger gameobjects in the scene to calculate the endoscope's current length in the Training scenario.
 * \author Athanasios Irodotou 2013
 */
public class LengthCollisionTr : MonoBehaviour 
{
	public GameObject fpcObject; /**< A reference to the FPC gameObject. */

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
	 * This method checks for collisions between the invisible triggers and the FPC (endoscope) object.
	 * It then dynamically increments the length travelled variable shown in the HUD.
	 * \param myTrigger is the currently colliding gameObject i.e. the FPC object.
	 */		
	void OnTriggerEnter(Collider myTrigger) 
	{
		if (myTrigger.gameObject.name == fpcObject.name)
		{
			
			if (gameObject.name == "DistanceCollider1")
			{
<<<<<<< HEAD
=======
//				print ("sending length1");	
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
				TrainingController.sessionLength = TrainingController.sessionLength + 15;
				Destroy(gameObject);
			} 
			else if (gameObject.name == "DistanceCollider2")
			{
<<<<<<< HEAD
=======
//				print ("sending length2");	
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
				TrainingController.sessionLength = TrainingController.sessionLength + 25;
				Destroy(gameObject);
			}
			else if (gameObject.name == "DistanceCollider3")
			{
<<<<<<< HEAD
=======
//				print ("sending length3");	
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
				TrainingController.sessionLength = TrainingController.sessionLength + 25;
				Destroy(gameObject);
			}
			else if (gameObject.name == "DistanceCollider4")
			{
<<<<<<< HEAD
=======
//				print ("sending length4");	
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
				TrainingController.sessionLength = TrainingController.sessionLength + 26;
				Destroy(gameObject);
			}				
		}
	}
}
