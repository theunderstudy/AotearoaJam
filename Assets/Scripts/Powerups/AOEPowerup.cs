using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOEPowerup : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        Player _player = other.gameObject.GetComponent<Player>();
        if (_player != null)
        {
            OverlapPlayer(_player);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Player _player = other.gameObject.GetComponent<Player>();
        if (_player != null)
        {
            EndOverlapPlayer(_player);
        }
    }

    protected virtual void OverlapPlayer(Player player)
    {

    }

    protected virtual void EndOverlapPlayer(Player player)
    {

    }


}
