using UnityEngine;
using System.Collections;

public class LesionCollision : MonoBehaviour 
{
	public GameObject fpcObject;
	public GameObject ObstaclesSet;
	private GameObject lesionTag;
	private bool isLesion;
	private string lesionObjectName;
	private bool success;
	
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
			print ("sending...");	
			TrainingController.sessionLesions = TrainingController.sessionLesions + 1;	
			ActOnLesion(gameObject.name);						
		}
	}
	
	void ActOnLesion (string name)
	{
		if (name.Contains("ObstacleSphere1"))
		{					
			ObstaclesSet.SendMessage("TurnOnOffLesions", 1);
			lesionTag = GameObject.Find("LesionTag1");
			lesionTag.SendMessage("DestroyTag", true);			
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere2"))
		{
			ObstaclesSet.SendMessage("TurnOnOffLesions", 2);
			lesionTag = GameObject.Find("LesionTag2");
			lesionTag.SendMessage("DestroyTag", true);
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere3"))
		{
			ObstaclesSet.SendMessage("TurnOnOffLesions", 3);
			//lesionTag = GameObject.Find("LesionTag2");
			//lesionTag.SendMessage("DestroyTag", true);
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere4"))
		{
			ObstaclesSet.SendMessage("TurnOnOffLesions", 4);
			//lesionTag = GameObject.Find("LesionTag2");
			//lesionTag.SendMessage("DestroyTag", true);
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere5"))
		{
			ObstaclesSet.SendMessage("TurnOnOffLesions", 5);
			//lesionTag = GameObject.Find("LesionTag2");
			//lesionTag.SendMessage("DestroyTag", true);
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere6"))
		{
			ObstaclesSet.SendMessage("TurnOnOffLesions", 6);
			//lesionTag = GameObject.Find("LesionTag2");
			//lesionTag.SendMessage("DestroyTag", true);
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere7"))
		{
			//lesionTag = GameObject.Find("LesionTag2");
			//lesionTag.SendMessage("DestroyTag", true);
			Destroy(gameObject);	
		}
		
		
	}
}
