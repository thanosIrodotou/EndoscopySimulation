using UnityEngine;
using System.Collections;

/**
 * The SimulationLesionCollision checks for collisions between lesions objects and the endoscopic unit.
 * It acts accordingly by enabling different lesions enforcing a pattern of lesions identification and collection based on the Low/High Realism Simulation scenarios.
 * See LesionCollision.cs for more information.
 * \author Athanasios Irodotou 2013
 */
public class SimulationLesionCollision : MonoBehaviour 
{
	public GameObject fpcObject;
	public GameObject ObstaclesSet;
	private bool isLesion;
	private string lesionObjectName;
	private bool success;
	private bool waterLesionCase = false;
	public Texture waterTexture;
	public Texture normalTexture;
	
	// Use this for initialization
	void Start () 
	{		

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gameObject.name == "ObstacleSphere2" || gameObject.name == "ObstacleSphere3") 
		{
			waterLesionCase = true;
			renderer.material.mainTexture = waterTexture;
		}		
		else 
		{
			renderer.material.mainTexture = normalTexture;
		}				
	}
	
	void OnTriggerEnter(Collider myTrigger) 
	{		
		if (myTrigger.gameObject.name == fpcObject.name)
		{
			if (!waterLesionCase)
			{
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
			}
			
			ActOnLesion(gameObject.name);						
		}
	}
	
	void ActOnLesion (string name)
	{
		if (name.Contains("ObstacleSphere1"))
		{				
			ObstaclesSet.SendMessage("TurnOnLesion", 1);						
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere4"))
		{	
			Destroy(gameObject);
		}	
	}
}
