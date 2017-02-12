using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour {

	protected int clipSize;
	protected int ammo;
	protected float speed;
	public GameObject bulletPrefab;
	public GameObject bulletSpawn;
	public float shotTime;
	public float shotInterval;
	public float reloadTime;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// only shoot when there are bullets and it's time to shoot
		if (ammo>0 && Time.time>shotTime && Input.GetButton("Fire1")){
			Shoot();
			shotTime = Time.time+shotInterval; // set next shot time
		}
		// only reload when out of bullets and there are ammo clips:
		if (ammo==0){
			Reload ();
			shotTime = Time.time + reloadTime; // set reload time
		}
	
		
		if (Input.GetKeyDown ("r")) {
			Reload ();
			shotTime = Time.time + reloadTime;
		}
	
	}

	// Shoot
	void Shoot() {	

			GameObject bullet = Instantiate (bulletPrefab, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
			//Debug.Log ("bullet works");

			bullet.transform.forward = transform.forward;

			// Add velocity to the bullet

		bullet.GetComponent<Rigidbody> ().AddForce (transform.forward * speed);
			//Debug.Log ("moving");    


			// Destroy bullet after 2 seconds
			Destroy(bullet, 2.0f);

			ammo--;
		}       

	// Reload
	void Reload() {
		ammo = clipSize;
	}
		
}


