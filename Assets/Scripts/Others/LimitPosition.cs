using UnityEngine;
using System.Collections;

public class LimitPosition : MonoBehaviour 
{
	
	public Vector3 endoscopePosition;

	public bool startPosLimitToggle = false;
	public bool endPosLimitToggle = false;
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	//Get message from collider and handle object's position
	public void limitStartingPosition (bool limitToggle)
	{
		if (startPosLimitToggle)
		{
			print ("got it");
			gameObject.transform.position = new Vector3(1.604631f, 0.5262575f, -0.5985594f);				
		}
	}	
	
	public void limitEndingPosition (bool limitToggle)
	{
		if (endPosLimitToggle)
		{
			print ("got it");
			gameObject.transform.position = new Vector3(-0.620811f, 0.5555466f, 0.01f);
		}
	}
}
