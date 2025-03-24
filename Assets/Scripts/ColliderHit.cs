using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NodeCanvas.Framework;

public class ColliderHit : MonoBehaviour
{
    public int enemyTarget;
    public GameObject hunter;
    public float detectionRadius = 5f;

    void Update()
    {
        Collider[] hitColliders = Physics.OverlapSphere(hunter.transform.position, detectionRadius);
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.CompareTag("Enemy"))
            {
                if (hitCollider.gameObject.name == "Enemy1")
                {
                    enemyTarget = 1;
                }

                else if (hitCollider.gameObject.name == "Enemy2")
                {
                    enemyTarget = 2;
                }

                else if (hitCollider.gameObject.name == "Enemy3")
                {
                    enemyTarget = 3;
                }
            }
        }
    }
}
