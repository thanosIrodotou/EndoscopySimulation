using UnityEngine;
using System.Collections;

/**
 * The RaycastCollision checks for ray collisions between the FPC object's invisible ray and the 3d models, esophagus, stomach, duodenum.
 * If the length of the ray shot from the FPC object is of a predefined value (0.05f), then the blood particles are emitted and the patient discofort value increases.
 * \author Athanasios Irodotou 2013
 */
public class RaycastCollision : MonoBehaviour
{
	public float collisionDistance; /**< A float to represent the ray's length. */
	private bool collided; /**< A boolean to check if the ray has collided with anything. */
	public GameObject objectTransform; /**< The transform values of the FPC gameObject, used to assign the Ray's origin. */
	public ParticleEmitter bloodDrops; /**< A ParticleEmitter type var to store the blood drops particle system. */
	public ParticleEmitter bloodMain; /**< A ParticleEmitter type var to store the blood main particle system. */

	// Use this for initialization
	void Start ()
	{
		
	}
	
	
	// Update is called once per frame
	/**
	 * The Update method is another MonoBehaviour inherited method. The Update method is called every frame.
	 * It creates an invisible ray every frame from the FPC object's tip forward and checks for collisions between the ray and any mesh tagged "TractCollision".
	 */	
	void Update () 
	{				
		Vector3 fwd = objectTransform.transform.TransformDirection(Vector3.forward);
		RaycastHit hit;
		
		Ray collisionRay = new Ray(objectTransform.transform.position, fwd);
		
<<<<<<< HEAD
   		Debug.DrawRay(objectTransform.transform.position, fwd * 1, Color.red);
=======
<<<<<<< HEAD
   		Debug.DrawRay(objectTransform.transform.position, fwd * 1, Color.red);
=======
   		//Debug.DrawRay(objectTransform.transform.position, fwd * 1, Color.red);
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
		
		if (!collided)
		{
			if (Physics.Raycast(collisionRay, out hit, collisionDistance))
			{
				if (hit.collider.tag == "TractCollision")
				{
<<<<<<< HEAD
					if (Time.timeScale != 0.0f)
					{
						calculateDiscomfort();
						bloodDrops.emit = true;
						bloodMain.emit = true;
					}						
				}	
			}
			else
			{
				bloodDrops.emit = false;
				bloodMain.emit = false;
=======
<<<<<<< HEAD
					if (Time.timeScale != 0.0f)
						showBlood();	
=======
					showBlood();	
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
				}				
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
			}
		}
	}
	

	/**
	 * This method is called when a collision between the invisible ray and meshes tagged as "TractCollision".
	 * It simply increases the discomfort level by 0.01f for as long as raycast collision is true.
	 */		
	void calculateDiscomfort () 
	{
		collided = true;	
			
		if (Application.loadedLevel == 9)
		{
			SimulationControllerHigh.sessionDiscomfortLevel += 0.01f;
		}
		else if (Application.loadedLevel == 6)
		{
			TrainingController.sessionDiscomfortLevel += 0.01f;
		}
		else if (Application.loadedLevel == 1)
		{
			SimulationControllerLow.sessionDiscomfortLevel += 0.01f;	
		}
		collided = false;
	}
}
