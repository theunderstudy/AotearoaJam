using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed = 5;

    public float TimeBetweenShots = 1;
    private float CurrentTime = 0;

    public PlayerBullet BulletPrefab;

    public Package AttachedPackage;
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
        PlayerBullet Bullet = Instantiate(BulletPrefab);
        //Vector3 shootDirection;
        //Vector3 mousePosition = Input.mousePosition;
        //mousePosition.z = (transform.position-Camera.main.transform.position ).z;
        //shootDirection = Camera.main.ScreenToWorldPoint(mousePosition);
       
        //Bullet.MovementDirection = shootDirection.normalized;

        Bullet.transform.position = transform.position;

    }


    public bool PackageAttached()  { return AttachedPackage != null; }
    public void AttachPackage(Package package)
    {
        if (AttachedPackage != null)
        {
            AttachedPackage.Destroy();

            AttachedPackage = null;
        }

        AttachedPackage = package;

        AttachedPackage.transform.parent = transform;
        AttachedPackage.transform.localPosition = Vector3.zero;
    }

    public void DeliverAttachedPackage()
    {
        if (AttachedPackage != null)
        {
            AttachedPackage.Deliver();
        }
    }
    
}
