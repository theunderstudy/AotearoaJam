using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public float MoveSpeed = 2;

    public int Score = 10;

    // Update is called once per frame
    void Update()
    {
        transform.position += -Vector3.up * Time.deltaTime * MoveSpeed;
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        Player _player = col.gameObject.GetComponent<Player>();
        if (_player != null)
        {
            CollideWithPlayer(_player);
        }
    }


    protected virtual void CollideWithPlayer(Player player)
    {

    }
    public virtual void CollideWithProjectile(Projectile projectile)
    {
        Destroy(gameObject);
    }

}
