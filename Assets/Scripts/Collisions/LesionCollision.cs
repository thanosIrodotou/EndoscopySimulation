using UnityEngine;
using System.Collections;

public class LesionCollision : MonoBehaviour 
{
	public GameObject fpsObject;

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
		if (myTrigger.gameObject.name == fpsObject.name)
		{
			print ("sending...");	
			TrainingController script;
			TrainingController.lesions = TrainingController.lesions + 1;		
		}
	}
}
