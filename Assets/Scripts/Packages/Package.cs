using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        Player _player = other.gameObject.GetComponent<Player>();
        if (_player != null)
        {
            OverlapPlayer(_player);
        }
    }


    protected virtual void OverlapPlayer(Player player)
    {
        // Attach to player
        if (!player.PackageAttached())
        {
            player.AttachPackage(this);

        }

    }

    public void Deliver()
    {
        // Reward points
        UI.Instance.ChangeScore(100);
        Destroy();
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }


}
