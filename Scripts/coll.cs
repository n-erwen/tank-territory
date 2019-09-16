using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coll : MonoBehaviour {
	// Use this for initialization
	public ParticleSystem pExplosion;


	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//GameObject b_bullet = GameObject.Find ("goldShell");
		//if (b_bullet == null) {
			//GameObject.Find ("Red_Tank").GetComponent<Bullet_fire> ().b_fired = false;
		//}
	}
		
	void OnCollisionEnter(Collision collision) {
		GameObject Firer;
		string WhoFiredMe;
		print ("had a collision");
		print ("collided with " + collision.collider.ToString ());

		ParticleSystem pBoom = Instantiate (pExplosion, gameObject.transform.position, gameObject.transform.rotation) as ParticleSystem;
		pBoom.Play ();

		WhoFiredMe = gameObject.name.Replace ("Bullet", "");
		print ("I was fired by " + WhoFiredMe);

		Firer = GameObject.Find (WhoFiredMe);

		if (Firer != null) {
			print ("my name is " + Firer.name);
			Firer.GetComponent<GreyTankMovement>().bLiveBullet = false;
		}

		if (collision.gameObject.tag == "Tank") {
			Destroy (collision.gameObject);
		}

		Destroy (pBoom, 6.0f);
		Destroy (gameObject, 1.0f);


	}
}
