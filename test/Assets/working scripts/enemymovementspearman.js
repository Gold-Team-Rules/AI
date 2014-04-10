#pragma strict
var timer = 0.0f;
public var currentspeed = 2;
var turn = -1;

function Start () {

}

function Update () {
transform.Translate(Vector3.right * currentspeed * Time.deltaTime);
timer += Time.deltaTime;
if(timer > 5)
{
currentspeed= currentspeed*turn;
timer = 0.0;
}
}