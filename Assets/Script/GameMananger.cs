using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GameMananger : MonoBehaviour
{
    public float waveCount = 30f;
    public float timeWave;
    public Text textCountWave;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ResgTime();
    }

    void WaveEnemysSpawn()
    {
        
    }

    void ResgTime()
    {
        if(waveCount > 0.0f)
        {
            waveCount -= Time.deltaTime;
            textCountWave.text = waveCount.ToString();
        }
        else
        {
            textCountWave.text = "O resgate chegou!";
        }
    }
}
