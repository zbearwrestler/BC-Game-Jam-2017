using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon {

	// Use this for initialization
	void Start () {
		fireRate = 1;
		reloadRate = 1;
		clipSize = 10;
		ammo = clipSize;
		speed = 1;
		damage = 1;
		
	}

}
