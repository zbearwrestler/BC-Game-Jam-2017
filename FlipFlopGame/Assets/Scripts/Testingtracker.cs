using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testingtracker : MonoBehaviour {

    public Roundtracker rt;
	// Use this for initialization
	void Start () {
        rt = gameObject.GetComponent<Roundtracker>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.W))
        {
            rt.endround(true);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            rt.endround(false);
        }
	}
}
