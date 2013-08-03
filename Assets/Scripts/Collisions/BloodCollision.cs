using UnityEngine;
using System.Collections;

public class BloodCollision : MonoBehaviour 
{
	public GameObject fpcObject;
	public GameObject splattObject;

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
			print ("sending blood true");	
		 	splattObject.GetComponent<BloodSplatt>().enabled = true;
		}
	}
	
//	void OnTriggerExit (Collider myTrigger)
//	{
//		if (myTrigger.gameObject.name == fpcObject.name)
//		{
//			print ("sending blood false");	
//		 	splattObject.GetComponent<BloodSplatt>().enabled = false;
//		}		
//	}
	
	void OnTriggerStay(Collider myTrigger)
	{
        if (myTrigger.gameObject.name == fpcObject.name)
		{
			print ("staying");	
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
			
		}
        
    }	
}
