using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public float MoveSpeed = 2;

    public int Score = 10;

    public Vector3 DropDirection;


    public int lifeTime = 10;
    public float CurrentAge = 0;

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance.bGameRunning)
        {
            Destroy(gameObject);
            return;
        }
        transform.position += DropDirection * Time.deltaTime * MoveSpeed;

        CurrentAge += Time.deltaTime;

        if (CurrentAge > lifeTime)
        {
            Destroy(gameObject);
        }
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
