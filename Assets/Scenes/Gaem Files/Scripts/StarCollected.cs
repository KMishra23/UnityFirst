using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCollected : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player") 
        {
            ScoreCounter.starCounter++;
            Destroy(gameObject);
        }

    }
}
