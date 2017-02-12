using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Script : MonoBehaviour {

    public GameObject player;
    public float playerDistance;
    public float rotationDamping;
    public float moveSpeed;

	// Use this for initialization
	void Start () {
		if(player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
    }
	
	// Update is called once per frame
	void Update () {

        if (player.GetComponent<healthScript01>().isPlayerAlive)
        {
            playerDistance = Vector3.Distance(player.transform.position, transform.position);

            if (playerDistance < 25f)
            {
                lookAtPlayer();
            }
            if (playerDistance < 20f)
            {
                if (playerDistance > 12f)
                {
                    chase();
                }
                else if (playerDistance < 15f)
                {
                    attack();
                }
            }
        }
	}

    void lookAtPlayer()
    {
        Quaternion rotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationDamping);
    }

    void chase()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    void attack()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider.gameObject.tag == "Player")
            {
                if (hit.collider.gameObject.GetComponent<healthScript01>().health > 0f)
                {
                    hit.collider.gameObject.GetComponent<healthScript01>().health -= 5f;
                }

            }
        }
    }
}
