using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform spawnPosition;
    public GameObject spawnenemy;
    public float countEnemy;
    private int waveEnemy;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemysGame();
        
    }

    //Spawn inimigos
    void SpawnEnemysGame()
    {
      Instantiate(spawnenemy, spawnPosition.transform.position, Quaternion.identity);      
    }

}
