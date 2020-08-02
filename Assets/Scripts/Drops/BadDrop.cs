using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadDrop : Drop
{
    protected override void CollideWithPlayer(Player player)
    {
        base.CollideWithPlayer(player);

        UI.Instance.ChangeScore(Score);

        GameManager.Instance.Lives -= 1;

        Destroy(gameObject);
    }
}
