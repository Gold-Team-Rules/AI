﻿using UnityEngine;
using System.Collections;

public class MeleeEnemy : MonoBehaviour {
	public Transform sightStart;
	public Transform sightEnd;
	public bool spotted= false;
	public float timer = 1;
	int currentspeed = 4;
	int turn = -1;
	public Transform player;
	public int speed = 2;
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
	float dist = Vector3.Distance(player.position, transform.position);
		print("Distance to melee: " + dist);
		if (dist < 10 )

		spotted = true;

	}

void Behaviors ()
{ if (spotted == false) {
		transform.Translate(Vector3.right * currentspeed * Time.deltaTime);
		timer += Time.deltaTime;
		if(timer > 5)
		{
			currentspeed= currentspeed*turn;
			timer = 1;
		}
	}
	if (spotted == true){
		transform.Translate(new Vector3(speed* Time.deltaTime,0,0)); //this is where we figure what the enemy will do when they player is close enough
}
	}
}