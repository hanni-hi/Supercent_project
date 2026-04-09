using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : RespawnController
{
    [SerializeField] private int LifeCount=3;
    [SerializeField] private int RebornTime=5;
    [SerializeField] private bool isActivated = false;
    
    private int Count=0;

    private void Update()
    {
        if (Count >= LifeCount) Harvest();
    }

    private void Harvest()
    {
        Count = 0;
        HideAndRespawn(RebornTime);
    }

    private void OnMouseDown()
    {
        if (!isActivated) return;

        Count++;
        Debug.Log("Ã¤ÁýÁß : "+Count);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Activator"))
        {
            isActivated = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Activator"))
        {
            isActivated = false;
        }
    }

}
