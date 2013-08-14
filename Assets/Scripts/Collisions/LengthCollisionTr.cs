using UnityEngine;
using System.Collections;

public class LengthCollisionTr : MonoBehaviour 
{
	public GameObject fpcObject;

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
		if (myTrigger.gameObject.name == fpcObject.name)
		{
			
			if (gameObject.name == "DistanceCollider1")
			{
//				print ("sending length1");	
				TrainingController.sessionLength = TrainingController.sessionLength + 15;
				Destroy(gameObject);
			} 
			else if (gameObject.name == "DistanceCollider2")
			{
//				print ("sending length2");	
				TrainingController.sessionLength = TrainingController.sessionLength + 25;
				Destroy(gameObject);
			}
			else if (gameObject.name == "DistanceCollider3")
			{
//				print ("sending length3");	
				TrainingController.sessionLength = TrainingController.sessionLength + 25;
				Destroy(gameObject);
			}
			else if (gameObject.name == "DistanceCollider4")
			{
//				print ("sending length4");	
				TrainingController.sessionLength = TrainingController.sessionLength + 26;
				Destroy(gameObject);
			}				
		}
	}
}
