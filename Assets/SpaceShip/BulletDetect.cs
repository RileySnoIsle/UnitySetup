using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDetect : MonoBehaviour
{
    public int health;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "Bullet")
        {
            transform.localScale *= 0.95f;
            health--;
            if (health < 1)
            {
                Destroy(this.gameObject);
            }
        }
        

    }

}
