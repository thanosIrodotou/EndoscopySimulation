using UnityEngine;
using System.Collections;

public class RaycastCollision : MonoBehaviour
{
	public float collisionDistance;
	private bool collided;
	public GameObject splattObject;
	public GameObject objectTransform;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{				
		Vector3 fwd = objectTransform.transform.TransformDirection(Vector3.forward);
		RaycastHit hit;
		
		Ray collisionRay = new Ray(objectTransform.transform.position, fwd);
		
<<<<<<< HEAD
   		Debug.DrawRay(objectTransform.transform.position, fwd * 1, Color.red);
=======
   		//Debug.DrawRay(objectTransform.transform.position, fwd * 1, Color.red);
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
		
		if (!collided)
		{
			if (Physics.Raycast(collisionRay, out hit, collisionDistance))
			{
				if (hit.collider.tag == "esophagusSideCollision")
				{
<<<<<<< HEAD
					if (Time.timeScale != 0.0f)
						showBlood();	
=======
					showBlood();	
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
				}				
			}
		}
	}
	
	void showBlood () 
	{
		collided = true;
		splattObject.GetComponent<BloodSplatt>().enabled = true;
			
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
