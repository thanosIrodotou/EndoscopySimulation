using UnityEngine;
using System.Collections;

/**
 * This class checks for collision with invisible trigger gameobjects in the scene to calculate the endoscope's current length in the High Realism simulation scenario.
 * See LengthCollisionTr.cs class for more information.
 * \author Athanasios Irodotou 2013
 */
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
				SimulationControllerHigh.sessionLength = SimulationControllerHigh.sessionLength + 15;
				Destroy(gameObject);
			} 
			else if (gameObject.name == "DistanceCollider2")
			{
				SimulationControllerHigh.sessionLength = SimulationControllerHigh.sessionLength + 25;
				Destroy(gameObject);
				GameObject.Find("esophagus").GetComponent<iTween>().enabled = false;
				GameObject.Find("stomach").GetComponent<iTweenEvent>().enabled = true;
			}
			else if (gameObject.name == "DistanceCollider3")
			{						
				SimulationControllerHigh.sessionLength = SimulationControllerHigh.sessionLength + 25;
				Destroy(gameObject);
				GameObject.Find("stomach").GetComponent<iTween>().enabled = false;	
				GameObject.Find("duodenum").GetComponent<iTweenEvent>().enabled = true;	
			}
			else if (gameObject.name == "DistanceCollider4")
			{
				SimulationControllerHigh.sessionLength = SimulationControllerHigh.sessionLength + 26;
				Destroy(gameObject);
			}				
		}
	}
}
