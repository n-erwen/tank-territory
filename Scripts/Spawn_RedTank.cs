using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_RedTank : MonoBehaviour {
	public GameObject RedTank;
	public Transform RedSpawn_point;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		GameObject Red_Tank_Player = GameObject.Find("Red_Tank");
		if (Red_Tank_Player == null) {
			GameObject Red_Tank = Instantiate (RedTank, RedSpawn_point.position, RedSpawn_point.rotation);
			Red_Tank.name = "Red_Tank";
		}
	}
}
