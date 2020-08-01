using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : Projectile
{
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Enemy"))
        {
            Drop _drop = other.GetComponent<Drop>();
            _drop.CollideWithProjectile(this);
            Destroy(gameObject);
        }
        
    }
}
