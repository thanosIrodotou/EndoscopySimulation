using UnityEngine;
using System.Collections;

/**
 * This is the WaterSprayManager class. It activates and deactivates the water spray module of the endoscope based on user's input.
 * While the "left shift" keyoboard key is pressed during simulation, this class sets the emit option of the Ellipsoid Particle Emitter to true.
 * \author Athanasios Irodotou 2013
 */
public class WaterSprayManager : MonoBehaviour 
{	
	public ParticleEmitter waterPump; /**< The Ellipsoid Particle Emitter gameObject is assigned in this variable. */
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	
	// Update is called once per frame
	/**
	 * The Update method is another MonoBehaviour inherited method. The Update method is called every frame.
	 * It calles the InputManager() method once every frame to check if the "left shift" key was pressed.
	 */ 	
	void Update () 
	{		
		InputManager();
	}

	
	/**
	 * The InputManager() method is called every frame by the Update() method to check whether the user has pressed the "left shift" keyboard key.
	 * If the key was pressed the emit property of the Ellipsoid Particle Emitter component of the "Water Pump" gameObject is set to true.
	 */	
	void InputManager()
	{
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