using NodeCanvas.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public GameObject enemy;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            enemy.SetActive(true);
        }
        
    }
}
