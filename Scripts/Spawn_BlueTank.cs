using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_BlueTank : MonoBehaviour {
	public GameObject BlueTank;
	public Transform BlueSpawn_point;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		GameObject Blue_Tank_Player = GameObject.Find("Blue_Tank");
		if (Blue_Tank_Player == null) {
			GameObject Blue_Tank = Instantiate (BlueTank, BlueSpawn_point.position, BlueSpawn_point.rotation);
			Blue_Tank.name = "Blue_Tank";
		}
	}
}