using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaKill : MonoBehaviour
{
    public CheckPointer cp;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            cp.ResetToLastCheckpoint();
        }
    }
}
