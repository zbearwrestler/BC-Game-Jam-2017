using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour {
    int health = 10;
    int healthloss = 0;
    bulletscript temp;
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Bullet")
        {
            temp = col.gameObject.GetComponent<bulletscript>();
            healthloss = health - temp.dmg;
            temp.dmg -= health;
            health -= healthloss;
            if(temp.dmg <= 0)
            {
                Destroy(col.gameObject);
            }

            if(health <= 0)
            {
                Destroy(gameObject);
            }

        }
    }

}
