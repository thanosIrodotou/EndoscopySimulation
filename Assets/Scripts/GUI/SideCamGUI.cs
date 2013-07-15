using UnityEngine;
using System.Collections;

public class SideCamGUI : MonoBehaviour 
{
	public Camera sideCam;

	// Use this for initialization
	void Start () 
	{
		Screen.SetResolution(1024, 768, true, 60);	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//sideCam.enabled = false;
	
	}
}
