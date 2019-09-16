using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlag : MonoBehaviour {
	public GameObject g_flag;
	public Transform Flag_spawnpoint;

	// Use this for initialization
	void Start () {
		GameObject fLag = Instantiate (g_flag, Flag_spawnpoint.position, Flag_spawnpoint.rotation);
		fLag.name = "Flag";
	}

	// Update is called once per frame
	void Update () {
		float flag_x = Flag_spawnpoint.position.x;
		float flag_y = Flag_spawnpoint.position.y;
		float flag_z = Flag_spawnpoint.position.z;

		GameObject Flag_exist = GameObject.Find ("Flag");
		if (Flag_exist == null) {
			flag_x += Random.Range (-10, 10);
			flag_y += Random.Range (-10, 10);
			flag_z += Random.Range (-10, 10);
			Flag_spawnpoint.position = new Vector3 (flag_x, flag_y, flag_z);
			GameObject fLag = Instantiate (g_flag, Flag_spawnpoint.position, Flag_spawnpoint.rotation);
			fLag.name = "Flag";
		}
	}
}