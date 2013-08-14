using UnityEngine;
using System.Collections;

public class ParticleLesionCollision : MonoBehaviour 
{	
	private GameObject lesionTag;
	public GameObject ObstaclesSet;
	
	// Use this for initialization
	void Start () 
	{
	
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
			Destroy(GameObject.Find("ObstacleSphere2"));
			TrainingController.sessionLesions = TrainingController.sessionLesions + 1;
			ObstaclesSet.SendMessage("TurnOnLesions", 2);			
			lesionTag = GameObject.Find("LesionTag2");
			lesionTag.SendMessage("DestroyTag", true);            
		}
    }
}
