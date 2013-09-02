using UnityEngine;
using System.Collections;

/**
 * The SimulationParticleLesionCollision checks for collisions between the water spray's particles and lesions objects to simulate water disolvable lesions in the Low/High Realism Simulation scenarios.
 * See ParticleLesionCollision.cs for more information.
 * \author Athanasios Irodotou 2013
 */
public class SimulationParticleLesionCollision : MonoBehaviour 
{	
	private GameObject lesionTag;
	public GameObject ObstaclesSet;
	
	// Use this for initialization
	void Start () 
	{
		print (Application.loadedLevelName);
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	void OnParticleCollision(GameObject other) 
	{		
        Rigidbody body = other.rigidbody;
        if (body) 
		{		
			if (body.name == "ObstacleSphere2")
			{
				Destroy(GameObject.Find("ObstacleSphere2"));
				
				if (Application.loadedLevelName == "simulationSceneLow")
				{
					SimulationControllerLow.sessionLesions = SimulationControllerLow.sessionLesions + 1;		
					print ("low");
				}					
				else if (Application.loadedLevelName == "simulationSceneHigh")
				{
					SimulationControllerHigh.sessionLesions = SimulationControllerHigh.sessionLesions + 1;
					print ("high");
				}				
				
				ObstaclesSet.SendMessage("TurnOnLesion", 2);			            	
			}			
			else if (body.name == "ObstacleSphere3")
			{				
				Destroy(GameObject.Find("ObstacleSphere3"));		
								
				if (Application.loadedLevelName == "simulationSceneLow")
				{
					SimulationControllerLow.sessionLesions = SimulationControllerLow.sessionLesions + 1;		
					print ("low");
				}					
				else if (Application.loadedLevelName == "simulationSceneHigh")
				{
					SimulationControllerHigh.sessionLesions = SimulationControllerHigh.sessionLesions + 1;
					print ("high");
				}
					
				
				ObstaclesSet.SendMessage("TurnOnLesion", 3);			            	
			}
			
		}
    }
}
