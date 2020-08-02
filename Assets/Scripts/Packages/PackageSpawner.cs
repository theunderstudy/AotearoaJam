using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageSpawner : MonoBehaviour
{
    public Package[] PackagePrefabs;

    private Package LivePackage;
    void Update()
    {
        if (LivePackage== null)
        {
            SpawnPackage();
        }
    }


    private void SpawnPackage()
    {
        LivePackage = Instantiate(PackagePrefabs[Random.Range (0,PackagePrefabs.Length)]);
        LivePackage.transform.position = RandomPointInBounds(GetComponent<BoxCollider2D>().bounds);
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
