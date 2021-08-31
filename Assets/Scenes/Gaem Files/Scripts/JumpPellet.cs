using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPellet : MonoBehaviour
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
        if (Physics.OverlapSphere(transform.position, 0.5f, pLayer).Length > 0 && isEnabled)
        {
            pl.hitJumpPellet();
            Destroy(child);
            isEnabled = false;
            coolDown = Time.time;
        }
        if(!isEnabled && Time.time - coolDown > 10)
        {
            child = Instantiate(baseMesh, new Vector3(transform.position.x + 0.4f, transform.position.y, 0), Quaternion.Euler(90,0,0), transform);
            isEnabled = true;
        }
    }
}
