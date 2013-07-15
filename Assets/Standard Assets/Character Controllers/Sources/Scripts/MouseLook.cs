using UnityEngine;
using System.Collections;

/// MouseLook rotates the transform based on the mouse delta.
/// Minimum and Maximum values can be used to constrain the possible rotation

/// To make an FPS style character:
/// - Create a capsule.
/// - Add the MouseLook script to the capsule.
///   -> Set the mouse look to use LookX. (You want to only turn character but not tilt it)
/// - Add FPSInputController script to the capsule
///   -> A CharacterMotor and a CharacterController component will be automatically added.

/// - Create a camera. Make the camera a child of the capsule. Reset it's transform.
/// - Add a MouseLook script to the camera.
///   -> Set the mouse look to use LookY. (You want the camera to tilt up and down like a head. The character already turns.)
[AddComponentMenu("Camera-Control/Mouse Look")]
public class MouseLook : MonoBehaviour {

	public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
	public RotationAxes axes = RotationAxes.MouseXAndY;
	public float sensitivityX = 15F;
	public float sensitivityY = 15F;

	private float minimumX = -90f;
	private float maximumX = 90f;

	private float minimumY = -90F;
	private float maximumY = 90F;

	float rotationY = 0F;
	//float rotationX = 0F;
	//Vector3 tempMousePosition = Input.mousePosition;

	void Update ()
	{
		if (axes == RotationAxes.MouseXAndY)
		{			 
//			//transform.eulerAngles = Vector3(0, curAngle % 360, 0);
//			rotationX += Input.GetAxis("Mouse X") * sensitivityX;
//        	rotationX = Mathf.Clamp (rotationX, minimumX, maximumX);
// 
//       	 	rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
//        	rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
// 
//			transform.eulerAngles = new Vector3(-rotationY, rotationX, 0);
//			//Debug.Log(transform.localRotation);
//			//print (rotationX);
//			if (rotationX < 0)
//			{
//				//print ("Negative: " + rotationX);	
//			}
//			else if (rotationX > 0)
//			{
//				//print ("Positive: " + rotationX);	
//			}
//			
//			if (Input.GetKeyDown(KeyCode.W) && Input.mousePosition != tempMousePosition)
//			{
//				print ("W and Mouse down");
//				tempMousePosition = Input.mousePosition;
//			}
			float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;

			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
			rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);

			transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
			
		}
		else if (axes == RotationAxes.MouseX)
		{
			print (Input.GetAxis("Mouse X") + ", " + transform.rotation);
			transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
		}
		else
		{
			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
			rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
			
			transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
		}
	}
	
	void Start ()
	{
		// Make the rigid body not change rotation
		if (rigidbody)
			rigidbody.freezeRotation = true;
	}
}