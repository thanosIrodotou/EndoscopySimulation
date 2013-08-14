using UnityEngine;
using System.Collections;

public class WaterSprayManager : MonoBehaviour 
{
	
	public ParticleEmitter waterPump;

	// Use this for initialization
	void Start () {
		//GameObject.Find("esophags1").animation.Play();
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (waterPump.emit == false) 
		{
			if(Input.GetKey(KeyCode.LeftShift) || Input.GetButton("WaterPump"))
			{	        
				waterPump.emit = true;
			}			
		}
		else if (waterPump.emit == true)
		{
			if(Input.GetKeyUp(KeyCode.LeftShift) || Input.GetButton("WaterPump"))
			{
				waterPump.emit = false;
			}	
		}	
		else 
		{
			waterPump.emit = false;	
		}

	}
	
}
