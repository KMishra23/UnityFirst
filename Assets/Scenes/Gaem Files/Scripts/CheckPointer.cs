using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPointer : MonoBehaviour
{
    private Vector3 lastCheckPosition;
    private Vector3 startPostion;

    public Transform player;

    void Start()
    {
        startPostion = new Vector3(-13, 5.84f, 0);
        lastCheckPosition = startPostion;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ResetToLastCheckpoint();
        }
    }

    public void ResetToLastCheckpoint()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//reloads scene
        player.position = lastCheckPosition;
    }

    public void UpdateCheckPoint(Vector3 position)
    {
        lastCheckPosition = position;
    }
}
