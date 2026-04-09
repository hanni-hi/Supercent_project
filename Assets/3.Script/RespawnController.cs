using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnController : MonoBehaviour
{
    private Collider col;
    private Renderer ren;

    private int time=0;

    private void Awake()
    {
        col = GetComponent<Collider>();
        ren = GetComponent<Renderer>();
    }

    public void HideAndRespawn(int RebornTime)
    {
        time = RebornTime;
        if (col != null) col.enabled = false;
        if (ren != null) ren.enabled = false;

        StartCoroutine(RebornRoutine());
    }

    private IEnumerator RebornRoutine()
    {
        yield return new WaitForSeconds(time);

        if (col != null) col.enabled = true;
        if (ren != null) ren.enabled = true;
    }

}
