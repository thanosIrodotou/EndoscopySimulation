using UnityEngine;
using System.Collections;

public class TurnOnLesionsAndTags : MonoBehaviour 
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
	
<<<<<<< HEAD
	void TurnOnLesions (int currentLesion)
	{
		activeLesions[currentLesion].SetActive(true);					
	}
	
	void TurnOnTags (int currentTag)
	{
		activeLesionTags[currentTag].SetActive(true);		
=======
	void TurnOnOffLesions (int currentLesion)
	{
		activeLesions[currentLesion].SetActive(true);
		activeLesionTags[currentLesion].SetActive(true);
		
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
	}
}
