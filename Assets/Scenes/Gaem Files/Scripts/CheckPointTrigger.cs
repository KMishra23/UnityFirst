using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointTrigger : MonoBehaviour
{
    public CheckPointer cpMaster;

    private void OnTriggerEnter(Collider other)
    {
        cpMaster.UpdateCheckPoint(transform.position);
    }
}
