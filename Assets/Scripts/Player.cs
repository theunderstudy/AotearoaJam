using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed=5;

    public float TimeBetweenShots = 1;
    private float CurrentTime = 0;

    public GameObject BulletPrefab;
    // Update is called once per frame
    void Update()
    {

        UpdatePosition();

        FireSequence();
    }
    private void UpdatePosition()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * MoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.right * MoveSpeed * Time.deltaTime * -1;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.up * MoveSpeed * Time.deltaTime * -1;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * MoveSpeed * Time.deltaTime;
        }
    }

    private void FireSequence()
    {
        CurrentTime += Time.deltaTime;

        if (CurrentTime > TimeBetweenShots)
        {
            FireBullet();
            CurrentTime = 0;
        }
    }

    private void FireBullet()
    {
        GameObject Bullet = Instantiate (BulletPrefab);

        Bullet.transform.position = transform.position;
    }

    
}
