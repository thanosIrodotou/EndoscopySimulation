using UnityEngine;
using System.Collections;

/**
 * This class turns on selections of lesion and lesion tag objects when required.
 * \author Athanasios Irodotou 2013
 */
public class TurnOnLesionsAndTags : MonoBehaviour 
<<<<<<< HEAD
{	
	public GameObject [] activeLesions; /**< This variable creates an array of GameObjects which is available for editing in the Editor. This way all lesion objects can be dragged and dropped in this array. */
	public GameObject [] activeLesionTags; /**< This variable creates an array of GameObjects which is available for editing in the Editor. This way all lesion tag objects can be dragged and dropped in this array. */
=======
{
	
	public GameObject [] activeLesions;
	public GameObject [] activeLesionTags;
<<<<<<< HEAD
=======
//	public enum Obstacles
//	{
//		ObstacleSphere1,
//		ObstacleSphere2,
//		ObstacleSphere3,
//		ObstacleSphere4,
//		ObstacleSphere5,
//		ObstacleSphere6,
//		ObstacleSphere7
//	};
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
	
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
	
<<<<<<< HEAD
	
	/**
	 * This method receives a lesion gameObject and sets its renderer parameter to active.
	 * \param currentLesion is the current tag object which needs to be enabled.
	 */		
=======
<<<<<<< HEAD
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
	void TurnOnLesions (int currentLesion)
	{
		activeLesions[currentLesion].SetActive(true);					
	}
	
<<<<<<< HEAD
	
	/**
	 * This method receives a lesion tag gameObject and sets its renderer parameter to active.
	 * \param currentTag is the current tag object which needs to be enabled.
	 */		
	void TurnOnTags (int currentTag)
	{
		activeLesionTags[currentTag].SetActive(true);		
=======
	void TurnOnTags (int currentTag)
	{
		activeLesionTags[currentTag].SetActive(true);		
=======
	void TurnOnOffLesions (int currentLesion)
	{
		activeLesions[currentLesion].SetActive(true);
		activeLesionTags[currentLesion].SetActive(true);
		
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
	}
}
