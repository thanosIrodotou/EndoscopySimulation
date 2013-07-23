using UnityEngine;
using System.Collections;

public class LimitEndPositionCollision : MonoBehaviour 
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
//		print (myTrigger.name);
		if (myTrigger.gameObject.name == fpsObject.name)
		{
			print ("sending...");	
			LimitPosition script;
			script = myTrigger.GetComponent<LimitPosition>();				
			script.endPosLimitToggle = true;
			script.limitEndingPosition(true);			
		}
	}	
}
