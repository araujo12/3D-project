using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform spawnPosition;
    public GameObject spawnenemy, bossEnemy;
    public float countEnemy;
    public float waveEnemy;

    void Start()
    {
        waveEnemy = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //SpawnEnemysGame();
        
    }

    //Spawn inimigos
    public void SpawnEnemysGame()
    {
        //primneira Orda de inimigos
      if(waveEnemy == 1)
        {
            if (countEnemy <= 19)
            {
                Instantiate(spawnenemy, spawnPosition.transform.position, Quaternion.identity);
                countEnemy++;
            }
            else
                waveEnemy = 2;           
        }
      //Segunda Orda de inimigos
      if(waveEnemy == 2)
        {
            if (countEnemy <= 29)
            {
                Instantiate(spawnenemy, spawnenemy.transform.position, Quaternion.identity);
                countEnemy++;
            }
            else
                waveEnemy = 3;
        }
      //Terceira orda de inimigos
      if(waveEnemy == 3)
        {
            if (countEnemy <= 39)
            {
                Instantiate(spawnenemy, spawnenemy.transform.position, Quaternion.identity);
                countEnemy++;
            }
            else
                waveEnemy = 4;
        }
      //Quarta Ora de inimigos
        if (waveEnemy == 4)
        {
            if (countEnemy <= 49)
            {
                Instantiate(spawnenemy, spawnenemy.transform.position, Quaternion.identity);
                countEnemy++;
            }
            else
                waveEnemy = 5;
        }
        //Boss Final
        if (waveEnemy == 5)
        {
            if (countEnemy == 0)
            {
                Instantiate(bossEnemy, bossEnemy.transform.position, Quaternion.identity);
                countEnemy++;

            }            

        }


    }

}
