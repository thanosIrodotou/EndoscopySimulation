using UnityEngine;
using System.Collections;

public class RenderBounds : MonoBehaviour 
{
	public Mesh aMeshObject;

	// Use this for initialization
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
