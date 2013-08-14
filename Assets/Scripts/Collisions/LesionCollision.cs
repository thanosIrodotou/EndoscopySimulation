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
	private bool waterLesionCase = false;
	public Texture waterTexture;
	public Texture normalTexture;
	private float pauseTime = 0.0f;
	
	// Use this for initialization
	void Start () 
	{		
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gameObject.name == "ObstacleSphere2") 
		{
			waterLesionCase = true;
			renderer.material.mainTexture = waterTexture;
		}		
		else 
		{
			renderer.material.mainTexture = normalTexture;
		}	
		
		if (gameObject.name == "StomachPause")
		{
			Time.timeScale = pauseTime;
			
			if (Input.GetKeyDown(KeyCode.Space))
			{
				pauseTime = 1.0f;
				lesionTag = GameObject.Find("LesionTag3");
				lesionTag.SendMessage("DestroyTag", true);
				lesionTag = GameObject.Find("LesionTag3.1");
				lesionTag.SendMessage("DestroyTag", true);
				lesionTag = GameObject.Find("LesionTag3.2");
				lesionTag.SendMessage("DestroyTag", true);
				ObstaclesSet.SendMessage("TurnOnLesions", 4);
			}
		}
	}
	
	void OnTriggerEnter(Collider myTrigger) 
	{		
		if (myTrigger.gameObject.name == fpcObject.name)
		{
//			print ("sending...");
			if (!waterLesionCase)
			{
				TrainingController.sessionLesions = TrainingController.sessionLesions + 1;		
			}
			
			ActOnLesion(gameObject.name);						
		}
	}
	
	void ActOnLesion (string name)
	{
		if (name.Contains("ObstacleSphere1"))
		{					
			ObstaclesSet.SendMessage("TurnOnLesions", 1);
			ObstaclesSet.SendMessage("TurnOnTags", 1);
			lesionTag = GameObject.Find("LesionTag1");
			lesionTag.SendMessage("DestroyTag", true);			
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere3"))
		{
			ObstaclesSet.SendMessage("TurnOnTags", 2);
			ObstaclesSet.SendMessage("TurnOnTags", 3);
			ObstaclesSet.SendMessage("TurnOnTags", 4);	
			ObstaclesSet.SendMessage("TurnOnLesions", 3);
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere4"))
		{
			ObstaclesSet.SendMessage("TurnOnLesionsAndTheirTags", 4);
			//lesionTag = GameObject.Find("LesionTag2");
			//lesionTag.SendMessage("DestroyTag", true);
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere5"))
		{
			ObstaclesSet.SendMessage("TurnOnLesionsAndTheirTags", 5);
			//lesionTag = GameObject.Find("LesionTag2");
			//lesionTag.SendMessage("DestroyTag", true);
			Destroy(gameObject);	
		}
		else if (name.Contains("ObstacleSphere6"))
		{
			ObstaclesSet.SendMessage("TurnOnLesionsAndTheirTags", 6);
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
