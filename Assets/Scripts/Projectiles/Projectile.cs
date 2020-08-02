using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Speed = 5;
    public Vector3 MovementDirection;


    public int lifeTime = 10;
    public float CurrentAge = 0;


    // Update is called once per frame
    void Update()
    {
        MoveBullet();

        if (CurrentAge > lifeTime)
        {
            Destroy(gameObject);
        }
    }

    void MoveBullet()
    {
        transform.position += MovementDirection * Time.deltaTime * Speed;
    }
}
