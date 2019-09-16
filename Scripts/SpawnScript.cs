using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {
	public GameObject GreyTank;
	public int numberOfTanks = 3;
	// Use this for initialization
	void Start () {

		for (int i = 1; i<=numberOfTanks; i++)
		{
			GameObject new_tank = GameObject.Find ("GreyTank" + i);
			if (new_tank == null) {
				GameObject  spawnPoint = GameObject.Find ("SpawnPoint_Grey" + i) as GameObject ;
				GameObject Tank = Instantiate (GreyTank, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject ;
				Tank.name = "GreyTank" + i;
			}
		}

	}

	// Update is called once per frame
	void Update () {

	}
}