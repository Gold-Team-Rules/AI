using UnityEngine;
using System.Collections;

public class raytest : MonoBehaviour {
	//public Vector3 sightStart;
    //public Vector3 sightEnd;
	public Transform sightStart;
	public Transform sightEnd;
	public bool spotted= false;
	public float timer = 1;
	int currentspeed = 4;
	 int turn = -1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Raycasting ();
		Behaviors ();
	}
	void Raycasting ()
	{
		//Debug.DrawLine(sightStart,sightEnd,Color.red);
		Debug.DrawLine(sightStart.position,sightEnd.position,Color.red);
		spotted = Physics2D.Linecast (sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer("Player"));
		}
	void Behaviors ()
	{ if (spotted == true) {
			transform.Translate(Vector3.right * currentspeed * Time.deltaTime);
			timer += Time.deltaTime;
			if(timer > 5)
			{
				currentspeed= currentspeed*turn;
				timer = 1;
			}
				}
	}
}