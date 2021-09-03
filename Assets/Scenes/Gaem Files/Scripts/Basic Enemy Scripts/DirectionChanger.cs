using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionChanger : MonoBehaviour
{
    [SerializeField] private LayerMask enemyMask;
    public BasicEnemy bse;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Enemy1")
        {
            bse.ChangeDirection();
        }
    }
}
