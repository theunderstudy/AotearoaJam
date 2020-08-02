using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destination : MonoBehaviour
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
        player.DeliverAttachedPackage();
    }
}
