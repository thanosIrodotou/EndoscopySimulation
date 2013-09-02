using UnityEngine;
using System.Collections;

/**
 * This class turns on a lesion object when required. Mostly used in the two simulation scenarios.
 * \author Athanasios Irodotou 2013
 */
public class TurnOnLesions : MonoBehaviour 
{	
	public GameObject [] activeLesions; /**< This variable creates an array of GameObjects which is available for editing in the Editor. This way all lesion objects that need to be dynamically turned on can be dragged and dropped in this array. */
	
	void Awake()
	{
		
	}


	// Use this for initialization
	void Start () 
	{

	}
	
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	
	/**
	 * This method receives a lesion gameObject and sets its renderer parameter to active.
	 * \param currentLesion is the current tag object which needs to be enabled.
	 */		
	void TurnOnLesion (int currentLesion)
	{
		activeLesions[currentLesion].SetActive(true);					
	}
}
