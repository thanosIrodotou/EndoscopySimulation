using UnityEngine;
using System.Collections;

public class LimitStartPositionCollision : MonoBehaviour 
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
			LimitPosition script;
			script = myTrigger.GetComponent<LimitPosition>();				
			script.startPosLimitToggle = true;
			script.limitStartingPosition(true);			
		}
	}
}
