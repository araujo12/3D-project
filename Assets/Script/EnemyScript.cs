using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float enemySpeed;
    private Transform enemyPosition;
    public GameObject target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyTargetPlayer();
        
    }

    void EnemyTargetPlayer()
    {
        enemyPosition = GameObject.FindGameObjectWithTag("Player").transform;

        if(enemyPosition.gameObject != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, enemyPosition.position, enemySpeed * Time.deltaTime);
        }
    }
    
}
