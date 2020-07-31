using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDropper : MonoBehaviour
{

    public GameObject[] DroppedPrefabs;
    public float DropTime = 5;
    public float DropTimeDegradation = 0.1f;
    float CurrentTime = 0;

    // Update is called once per frame
    void Update()
    {
        CheckDrops();
    }

    void CheckDrops()
    {
        CurrentTime += Time.deltaTime;
        if (CurrentTime > DropTime)
        {
            CurrentTime = 0;
            DropTime -= DropTimeDegradation;

            if (DropTime < 0.1f)
            {
                DropTime = 0.1f;
            }
            DropObject();
        }
    }
    void DropObject()
    {
        GameObject gameObject = Instantiate(DroppedPrefabs[Random.Range(0,DroppedPrefabs.Length-1)]);

        Vector3 DropPosition = RandomPointInBounds(GetComponent<Collider>().bounds);
        gameObject.transform.position = DropPosition; 
    }

    private Vector3 RandomPointInBounds(Bounds bounds)
    {
        return new Vector3(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y),
            Random.Range(bounds.min.z, bounds.max.z)
        );
    }
}
