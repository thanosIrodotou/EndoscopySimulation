private var alpha: float;

static var lineMaterial : Material;

private var vobj: GameObject;

private var boxCorners: Vector3[];

private var cb;

private var display = false;

private var hLabel: GameObject;
private var wLabel: GameObject;
private var dLabel: GameObject;


static function CreateLineMaterial()
{
    if( !lineMaterial ) {
        lineMaterial = new Material( "Shader \"Lines/Colored Blended\" {" +
            "SubShader { Pass { " +
            "    Blend SrcAlpha OneMinusSrcAlpha " +
            "    ZWrite Off Cull Off Fog { Mode Off } " +
            "    BindChannels {" +
            "      Bind \"vertex\", vertex Bind \"color\", color }" +
            "} } }" );
        lineMaterial.hideFlags = HideFlags.HideAndDontSave;
        lineMaterial.shader.hideFlags = HideFlags.HideAndDontSave;
    }
}

function OnPostRender() {
	if(!display) return;
	if(!boxCorners) return;
	if(boxCorners.length==0) return;
    CreateLineMaterial();
    lineMaterial.SetPass( 0 );
    GL.Color( Color(0,1,0,0.5) );
	GL.Begin( GL.LINES );
	var j1:int;
	for (var j=0; j<4; j++) {
	//GL.Color(Color.blue);
	GL.Vertex3(boxCorners[j].x,boxCorners[j].y,boxCorners[j].z);//top lines
	j1 = (j+1)%4;
	GL.Vertex3(boxCorners[j1].x,boxCorners[j1].y,boxCorners[j1].z);
	j1 = j + 4;
	//GL.Color(Color.red);
	GL.Vertex3(boxCorners[j].x,boxCorners[j].y,boxCorners[j].z);//vertical lines
	GL.Vertex3(boxCorners[j1].x,boxCorners[j1].y,boxCorners[j1].z);
	//GL.Color(Color.yellow);
	GL.Vertex3(boxCorners[j1].x,boxCorners[j1].y,boxCorners[j1].z);//bottom rectangle
	j1 = 4 + (j+1)%4;
	GL.Vertex3(boxCorners[j1].x,boxCorners[j1].y,boxCorners[j1].z);
	}
	GL.End();
}


function drawBox(scr:Component){
	display = !display;
	cb = scr;
	alpha = cb.alpha;
	boxCorners = cb.Corners().ToBuiltin(Vector3);
}