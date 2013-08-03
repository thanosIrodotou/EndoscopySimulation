var colliderBased: boolean = true;

var topFrontLeft: Vector3;
var topFrontRight: Vector3;
var topBackLeft: Vector3;
var topBackRight: Vector3;
var bottomFrontLeft: Vector3;
var bottomFrontRight: Vector3;
var bottomBackLeft: Vector3;
var bottomBackRight: Vector3;

var alpha: float;

private var corners: Array;

private var camerabbox;

private var bound: Bounds;

private var quat : Quaternion;


function Start() {
	camerabbox = GameObject.Find("Main Camera").GetComponent(RenderBounds);
	corners = new Array();
	alpha = transform.rotation.eulerAngles.y;
	//quat = transform.rotation;
	transform.rotation.eulerAngles.y = 0;
	if(colliderBased){
		var coll: Collider = GetComponent(Collider);
		bound = coll.bounds;
	}else{
		bound = new Bounds(transform.position, Vector3.zero);
		var meshes: Array;
		meshes = GetComponentsInChildren(MeshFilter);
		Debug.Log("renderers" + meshes.length);
		for(var ms : MeshFilter in meshes)	{
			bound.Encapsulate(ms.renderer.bounds);
		}
	}
	transform.rotation.eulerAngles.y = alpha;
	quat = Quaternion.AngleAxis(alpha,Vector3.up);
}

function UpdateCorners() {
	var scale: Vector3;
	
	var bc: Vector3 = bound.center;
	corners = new Array();
	topFrontRight = bc +  quat *Vector3.Scale(bound.extents, Vector3(1, 1, 1)); 
	corners.Push(topFrontRight);
	topFrontLeft = bc +  quat *Vector3.Scale(bound.extents, Vector3(-1, 1, 1)); 
	corners.Push(topFrontLeft);
	topBackRight = bc +  quat *Vector3.Scale(bound.extents, Vector3(1, 1, -1)); 
	//corners.Push(topBackRight);
	topBackLeft = bc +  quat *Vector3.Scale(bound.extents, Vector3(-1, 1, -1)); 
	corners.Push(topBackLeft);
	corners.Push(topBackRight);
	bottomFrontRight = bc +  quat *Vector3.Scale(bound.extents, Vector3(1, -1, 1)); 
	corners.Push(bottomFrontRight);
	bottomFrontLeft = bc +  quat *Vector3.Scale(bound.extents, Vector3(-1, -1, 1)); 
	corners.Push(bottomFrontLeft);
	bottomBackRight = bc +  quat *Vector3.Scale(bound.extents, Vector3(1, -1, -1)); 
	//corners.Push(bottomBackRight);
	bottomBackLeft = bc +  quat *Vector3.Scale(bound.extents, Vector3(-1, -1, -1)); 
	corners.Push(bottomBackLeft);
	corners.Push(bottomBackRight);
	
}

function Update () {
	UpdateCorners();
	Debug.DrawLine(topFrontLeft, topFrontRight);
	Debug.DrawLine(bottomFrontLeft, bottomFrontRight);
	Debug.DrawLine(topBackLeft, topBackRight);
	Debug.DrawLine(bottomBackLeft, bottomBackRight);
	Debug.DrawLine(topFrontLeft, topBackLeft);
	Debug.DrawLine(topFrontRight, topBackRight);
	Debug.DrawLine(bottomFrontLeft, bottomBackLeft);
	Debug.DrawLine(bottomFrontRight, bottomBackRight);
	Debug.DrawLine(topFrontLeft, bottomFrontLeft);
	Debug.DrawLine(topFrontRight, bottomFrontRight);
	Debug.DrawLine(topBackLeft, bottomBackLeft);
	Debug.DrawLine(topBackRight, bottomBackRight);
}

function Corners() {
	return corners;
}

function OnMouseDown() {
	Debug.Log("down");
	camerabbox.drawBox(this);
	Debug.Log("down");
}