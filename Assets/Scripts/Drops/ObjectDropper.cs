using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDropper : MonoBehaviour
{

    public Drop[] DroppedPrefabs;
    public float DropTime = 5;
    public float DropTimeDegradation = 0.1f;

    public float DropMin = 0.5f;
    float CurrentTime = 0;
    public Vector3 Dropdirection;
    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance.bGameRunning)
        {
            return;
        }

        CheckDrops();
    }

    void CheckDrops()
    {
        CurrentTime += Time.deltaTime;
        if (CurrentTime > DropTime)
        {
            CurrentTime = 0;
            DropTime -= DropTimeDegradation;

            if (DropTime < DropMin)
            {
                DropTime = DropMin;
            }
            DropObject();
        }
    }
    void DropObject()
    {
        Drop gameObject = Instantiate(DroppedPrefabs[Random.Range(0,DroppedPrefabs.Length)]);
        gameObject.DropDirection = Dropdirection;
        Vector3 DropPosition = RandomPointInBounds(GetComponent<Collider>().bounds);
        gameObject.transform.position = DropPosition; 
    }

    private Vector3 RandomPointInBounds(Bounds bounds)
    {
        return new Vector3(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y),
            0
        );
    }
}
