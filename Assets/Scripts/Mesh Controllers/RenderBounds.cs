using UnityEngine;
using System.Collections;

/**
 * This is the RenderBounds class. This class is used to re-render the bounds of meshes. This way some extensive camera clipping is avoided.
 * \author Athanasios Irodotou 2013
 */

public class RenderBounds : MonoBehaviour 
{
	public Mesh aMeshObject; /**< A variable holding the mesh whose bounds are ging to be re-rendered. */

	// Use this for initialization
	/**
	 * The Start method is a MonoBehaviour inherited method called once when the scene which is included in is first loaded. 
	 * When the scene is loaded and the selected mesh is visible, it gets the mesh filter component of the mesh object and calls the RecalculateBounds() method.
	 */	
	void Start () 
	{
		GetComponent<MeshFilter>().mesh = aMeshObject;
		aMeshObject.RecalculateBounds();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
