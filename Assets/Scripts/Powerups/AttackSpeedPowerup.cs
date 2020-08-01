using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpeedPowerup : AOEPowerup
{

    public float AttackSpeedMultiplyer = 1.5f;
    protected override void EndOverlapPlayer(Player player)
    {
        base.EndOverlapPlayer(player);
        player.TimeBetweenShots *= AttackSpeedMultiplyer;
    }

    protected override void OverlapPlayer(Player player)
    {
        base.OverlapPlayer(player);
        player.TimeBetweenShots /= AttackSpeedMultiplyer;

    }
}
