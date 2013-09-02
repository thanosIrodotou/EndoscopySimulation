using UnityEngine;
using System.Collections;
 
/**
 * This is the ObjectTagLabel class. This class is used to simulate realtime informative text hovering in front of lesion objects.
 * \author Athanasios Irodotou 2013
 */

[RequireComponent (typeof (GUIText))]
<<<<<<< HEAD
public class ObjectTagLabel : MonoBehaviour 
{
 
	public Transform target; /**< Object that this label should follow. */
	public Vector3 offset = Vector3.up; /**< Units in world space to offset; 1 unit above object by default. */
	public bool clampToScreen = false; /**< If true, label will be visible even if object is off screen. */
	public float clampBorderSize = 0.05f; /**< How much viewport space to leave at the borders when a label is being clamped. */
	public bool useMainCamera = true; /**< Use the camera tagged MainCamera. */
	public Camera cameraToUse ; /**< Only use this if useMainCamera is false. */
	Camera cam ; /**< A variable which creates a component in the Editor where a camera object in the scene can be assigned. */
	Transform thisTransform; /**< A Transform variable which references the transform values of the labeltag object.  */
	Transform camTransform; /**< If the user selects a camera other than the main camera of the scene this variable stores the transform values of that camera object. */
=======
<<<<<<< HEAD
public class ObjectTagLabel : MonoBehaviour 
{
 
	public Transform target;  // Object that this label should follow
	public Vector3 offset = Vector3.up;    // Units in world space to offset; 1 unit above object by default
	public bool clampToScreen = false;  // If true, label will be visible even if object is off screen
	public float clampBorderSize = 0.05f;  // How much viewport space to leave at the borders when a label is being clamped
	public bool useMainCamera = true;   // Use the camera tagged MainCamera
	public Camera cameraToUse ;   // Only use this if useMainCamera is false
	Camera cam ;
	Transform thisTransform;
	Transform camTransform;
=======
public class ObjectTagLabel : MonoBehaviour {
 
public Transform target;  // Object that this label should follow
public Vector3 offset = Vector3.up;    // Units in world space to offset; 1 unit above object by default
public bool clampToScreen = false;  // If true, label will be visible even if object is off screen
public float clampBorderSize = 0.05f;  // How much viewport space to leave at the borders when a label is being clamped
public bool useMainCamera = true;   // Use the camera tagged MainCamera
public Camera cameraToUse ;   // Only use this if useMainCamera is false
Camera cam ;
Transform thisTransform;
Transform camTransform;
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
 
	// Use this for initialization
	/**
	 * The Start method is a MonoBehaviour inherited method  called once when the scene which is included in is first loaded. 
	 * In this class the Start method makes sure all required transforms are initialised. It also checks if the main camera should be used or a user provided camera instead.
	 */	
	void Start () 
    {
	    thisTransform = transform;
	    if (useMainCamera)
	        cam = Camera.main;
	    else
	        cam = cameraToUse;
	    camTransform = cam.transform;
<<<<<<< HEAD
	} 
=======
<<<<<<< HEAD
	} 
=======
	}
 
>>>>>>> 1fa3b9e207dbce138dbaf5585b15b6ee98326c4f
>>>>>>> 9f1edfb2b5abdad31c478054209af1964fca0dc9
 
	/**
	 * The Update method is another MonoBehaviour inherited method. The Update method is called every frame.
	 * It simulates a text hovering effect similar to such effects in MMO games used to display character names above the 3d models head.
	 * This way, a informative text is provided in front of each lesion to explain the situation.
	 */ 
    void Update()
    {
        if (clampToScreen)
        {
            Vector3 relativePosition = camTransform.InverseTransformPoint(target.position);
            relativePosition.z =  Mathf.Max(relativePosition.z, 1.0f);
            thisTransform.position = cam.WorldToViewportPoint(camTransform.TransformPoint(relativePosition + offset));
            thisTransform.position = new Vector3(Mathf.Clamp(thisTransform.position.x, clampBorderSize, 1.0f - clampBorderSize),
                                             Mathf.Clamp(thisTransform.position.y, clampBorderSize, 1.0f - clampBorderSize),
                                             thisTransform.position.z);
        }
        else
        {
            thisTransform.position = cam.WorldToViewportPoint(target.position + offset);
        }
    }
	
	/*
	 * A method to destroy label tags of lesion objects in realtime. 
	 * The method is called when a lesion is collected, thus the lesion gameobject and its tag need to be destroyed.
	 * /param state if true the tag is destroyed.
	 */
	void DestroyTag(bool state)
	{
		if (state)		
			Destroy(gameObject);					
	}
}