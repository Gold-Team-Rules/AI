using UnityEngine;
using System.Collections;

public class archer : MonoBehaviour {
	public bool spotted= false;
	public Transform player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Raycasting ();
		Behaviors ();
	}

void Raycasting (){
	if (player) {
		float dist = Vector3.Distance(player.position, transform.position);
		print("Distance to archer: " + dist);
			if (dist < 30 )
				print("yes");
	}
}
void Behaviors (){

	}
}
