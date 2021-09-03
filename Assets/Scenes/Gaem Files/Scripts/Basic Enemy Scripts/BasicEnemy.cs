using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private Vector3 direction;
    private bool flag;
    private Rigidbody bodyRigid;

    public CheckPointer cp;

    void Start()
    {
        bodyRigid = gameObject.GetComponent<Rigidbody>();
        direction = new Vector3(1, 0, 0);
        bodyRigid.velocity = direction * speed;
        flag = false;
    }

    void Update()
    {
        if (flag)//direction changed
        {
            direction = -direction;
            bodyRigid.velocity = direction * speed;
            flag = false;
        }
    }

    public void ChangeDirection()
    {
        flag = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            cp.ResetToLastCheckpoint();
            bodyRigid.velocity = direction * speed;
        }
    }
}
