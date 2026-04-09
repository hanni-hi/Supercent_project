using System;
using System.Collections.Generic;
using UnityEngine;

public class SmallRock : RespawnController
{
    private int rebornTime = 5;

    public static event Action OnSmallRockCollected;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            HideAndRespawn(rebornTime);
            OnSmallRockCollected.Invoke();
        }
    }


}
