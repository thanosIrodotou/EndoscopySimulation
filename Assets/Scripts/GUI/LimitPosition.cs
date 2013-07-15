using UnityEngine;
using System.Collections;

public class LimitPosition : MonoBehaviour 
{
	
	public Vector3 endoscopePosition;
	public float minPosition = -0.6300000f;
	public float maxPosition = -0.6280000f;
	public bool positionLimitToggle = false;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		endoscopePosition = transform.position;
		//print (transform.position.x + ", " + transform.position.y + ", " + endoscopePosition.z);
		if (endoscopePosition.z >= minPosition && endoscopePosition.z <= maxPosition)
		{
			//print ("mesa");
			//gameObject.transform.position = new Vector3(1.593952f, 2.005023f, -0.5985594f);	
		}
	
	}
	
	//Get message from collider and handle object's position
	public void handlePosition (bool limitToggle)
	{
		if (positionLimitToggle)
		{
			print ("got it");
			gameObject.transform.position = new Vector3(1.593952f, 2.005023f, -0.5985594f);				
		}
	}	
}
