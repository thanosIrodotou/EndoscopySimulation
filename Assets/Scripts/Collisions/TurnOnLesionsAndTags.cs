using UnityEngine;
using System.Collections;

public class TurnOnLesionsAndTags : MonoBehaviour 
{
	
	public GameObject [] activeLesions;
	public GameObject [] activeLesionTags;
	
	void Awake()
	{
//	    string[] names = System.Enum.GetNames(typeof(Obstacles));
//	    for (int i = 0; i < names.Length; i++)
//	    {			
//	        activeLesions[i] = Resources.Load(names[i]) as GameObject;
//	    }
	}

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void TurnOnLesions (int currentLesion)
	{
		activeLesions[currentLesion].SetActive(true);					
	}
	
	void TurnOnTags (int currentTag)
	{
		activeLesionTags[currentTag].SetActive(true);		
	}
}
