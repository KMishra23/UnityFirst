using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashPelletHit : MonoBehaviour
{
    public RigidbodyPlayer pl;
    public LayerMask pLayer;
    public GameObject baseMesh;
    [SerializeField] private GameObject child;

    private float coolDown;

    private bool isEnabled;

    private void Start()
    {
        coolDown = Time.time;
        isEnabled = true;
    }

    private void Update()
    {
        if (Physics.OverlapSphere(transform.position, 0.3f, pLayer).Length > 0 && isEnabled)
        {
            pl.hitPellet();
            Destroy(child);
            isEnabled = false;
            coolDown = Time.time;
        }
        if (!isEnabled && Time.time - coolDown > 10)
        {
            child = Instantiate(baseMesh, new Vector3(transform.position.x + 0.4f, transform.position.y, 0), Quaternion.Euler(0, 0, 0), transform);
            isEnabled = true;
        }
    }
    /*public RigidbodyPlayer pl;
    public LayerMask pLayer;

    private void Update()
    {
        if(Physics.OverlapSphere(transform.position, 0.3f, pLayer).Length > 0)
        {
            pl.hitPellet();
            Destroy(gameObject);
        }
    }*/
}
