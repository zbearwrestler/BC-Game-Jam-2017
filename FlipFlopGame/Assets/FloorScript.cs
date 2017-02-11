using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour {
    int health = 10;
    int healthloss = 0;
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collide");
        if(col.gameObject.tag == "Bullet")
        {
            healthloss = health - col.gameObject.bulletscript.dmg;
            col.gameObject.bulletscript.dmg -= health;
            if(col.gameObject.bulletscript.dmg <= 0)
            {
                Destroy(col.gameObject);
            }

            if(health - healthloss <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                Destroy(col.gameObject);
            }
        }
    }

}
