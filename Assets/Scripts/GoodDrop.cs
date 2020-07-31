using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodDrop : Drop
{
    protected override void CollideWithPlayer(Player player)
    {
        base.CollideWithPlayer(player);

        UI.Instance.ChangeScore(Score);

        Destroy(gameObject);

    }
}
