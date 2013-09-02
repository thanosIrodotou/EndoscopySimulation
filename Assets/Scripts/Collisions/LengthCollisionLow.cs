using UnityEngine;
using System.Collections;

/**
 * This class checks for collision with invisible trigger gameobjects in the scene to calculate the endoscope's current length in the Low Realism simulation scenario.
 * See LengthCollisionTr.cs class for more information.
 * \author Athanasios Irodotou 2013
 */
public class LengthCollisionLow : MonoBehaviour 
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
				SimulationControllerLow.sessionLength = SimulationControllerLow.sessionLength + 15;
				Destroy(gameObject);
			} 
			else if (gameObject.name == "DistanceCollider2")
			{
				SimulationControllerLow.sessionLength = SimulationControllerLow.sessionLength + 25;
				Destroy(gameObject);
			}
			else if (gameObject.name == "DistanceCollider3")
			{
				SimulationControllerLow.sessionLength = SimulationControllerLow.sessionLength + 25;
				Destroy(gameObject);
			}
			else if (gameObject.name == "DistanceCollider4")
			{
				SimulationControllerLow.sessionLength = SimulationControllerLow.sessionLength + 26;
				Destroy(gameObject);
			}				
		}
	}
}
