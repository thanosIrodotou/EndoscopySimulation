using UnityEngine;
using System.Collections;

public class LengthCollisionHigh : MonoBehaviour 
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
				print ("sending length1");	
				SimulationControllerHigh.sessionLength = SimulationControllerHigh.sessionLength + 15;
				Destroy(gameObject);
			} 
			else if (gameObject.name == "DistanceCollider2")
			{
				print ("sending length2");	
				SimulationControllerHigh.sessionLength = SimulationControllerHigh.sessionLength + 25;
				Destroy(gameObject);
			}
			else if (gameObject.name == "DistanceCollider3")
			{
				print ("sending length3");	
				SimulationControllerHigh.sessionLength = SimulationControllerHigh.sessionLength + 25;
				Destroy(gameObject);
			}
			else if (gameObject.name == "DistanceCollider4")
			{
				print ("sending length4");	
				SimulationControllerHigh.sessionLength = SimulationControllerHigh.sessionLength + 26;
				Destroy(gameObject);
			}				
		}
	}
}
