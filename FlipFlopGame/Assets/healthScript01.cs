using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthScript01 : MonoBehaviour {

    public float health = 100f;
    public bool isPlayerAlive = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(health);
        if (health < 0f)
        {
            isPlayerAlive = false;
            Destroy(gameObject);
        }
	}
}
