using UnityEngine;
using System.Collections;

public class Coin : Pickup//inherit van pickup
{
    //override = je maakt een extensie van die functie
    public bool slowDownBool = false;
    public bool rotateBool = false;
    public GameObject coin;

    public override void PlayerHit(Player _GO)
    {
        base.PlayerHit(_GO);//roep de basis classe nog wel aan(dus de playerhit in pickup)
        //voeg hier code toe zo dat de speler zijn score omhoog gaat
        _GO.addScore(1);
        if (slowDownBool) { _GO.speed -= 0.25f; print("Player was slowed down from " + (_GO.speed + 0.25f) + " to " + _GO.speed); }
        if (rotateBool) { _GO.rotate = true; }
        Destroy(coin);
    }
}
