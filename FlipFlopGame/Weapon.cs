using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour {
	protected double fireRate;
	protected double reloadRate;
	protected int clipSize;
	protected int ammo;
	protected double speed;
	protected int damage;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("fire1")) {
			Shoot ();
		}
		
		if (Input.GetKeyDown ("r")) {
			Reload ();
		}
	}

	// Shoot
	void Shoot() {
		if (ammo == 0) {
			Reload ();
		} else {
			ammo -= 1;
		}
		// TODO: add dmg, if it hits a block/misses 

	}

	// Reload
	void Reload() {
		ammo = clipSize;
	}


}


