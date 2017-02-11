using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour {
	protected double fireRate;
	protected double reloadRate;
	protected int clipSize;
	protected int ammo;
	protected double speed;
	public GameObject bulletPrefab;
	public Transform bulletSpawn;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			Debug.Log ("fire");
			Shoot ();
		}
		
		if (Input.GetKeyDown ("r")) {
			Reload ();
		}
	}

	// Shoot
	void Shoot() {	
		//Create the Bullet from the Bullet Prefab
//
//		var bullet = (GameObject)Instantiate (bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
//
//		// Add velocity to the bullet
//		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;
//
//		// Destroy bullet after 2 seconds
//		Destroy(bullet, 2.0f);

//		if (ammo == 0) {
//			Reload ();
//		} else {
//			ammo -= 1;
//			if (ammo == 0) {
//				Reload ();
//			}
//			
//		}


	}

	// Reload
	void Reload() {
		ammo = clipSize;
	}


}


