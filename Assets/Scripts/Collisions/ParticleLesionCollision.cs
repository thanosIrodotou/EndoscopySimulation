using UnityEngine;
using System.Collections;

<<<<<<< HEAD
/**
 * The ParticleLesionCollision checks for collisions between the water spray's particles and lesions objects to simulate water disolvable lesions.
 * \author Athanasios Irodotou 2013
 */
public class ParticleLesionCollision : MonoBehaviour 
{	
	private GameObject lesionTag; /**< A var to represent tags for water disolvable lesions. */
	public GameObject ObstaclesSet; /**< A reference to the set of lesion gameObjects already assigned in the Editor. */
=======
public class ParticleLesionCollision : MonoBehaviour 
{	
	private GameObject lesionTag;
	public GameObject ObstaclesSet;
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
<<<<<<< HEAD
	
	/**
	 * This method receives a gameObject and checks for collision.
	 * It checks to see if the lesion gameObjects are water disolvable, increments the collected lesion's count on HUD and destroys the objects disolved.
	 * \param other is the currently colliding gameObject.
	 */		
	void OnParticleCollision(GameObject other) 
	{		
        Rigidbody body = other.rigidbody;
        if (body) 
		{		
			if (body.name == "ObstacleSphere2")
			{
				Destroy(GameObject.Find("ObstacleSphere2"));
				TrainingController.sessionLesions = TrainingController.sessionLesions + 1;
				ObstaclesSet.SendMessage("TurnOnLesions", 2);			
				lesionTag = GameObject.Find("LesionTag2");
				lesionTag.SendMessage("DestroyTag", true);            	
			}			
			else if (body.name == "ObstacleSphere4")
			{				
				TrainingController.sessionLesions = TrainingController.sessionLesions + 1;					
				Destroy(GameObject.Find("ObstacleSphere4"));				
			}
			
=======
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
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
		}
    }
}
