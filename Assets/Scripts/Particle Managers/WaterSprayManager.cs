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
			if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey (KeyCode.JoystickButton1))
			{	        
				Debug.Log("WaterPump DEACTIVATED");
				waterPump.emit = true;
			}			
		}
		else if (waterPump.emit == true)
		{
			if(Input.GetKeyUp(KeyCode.LeftShift)  || Input.GetKey (KeyCode.JoystickButton1))
			{
				Debug.Log("WaterPump ACTIVATED");	       
				waterPump.emit = false;
			}	
		}	
		else 
		{
			waterPump.emit = false;	
		}

	}
	
}
