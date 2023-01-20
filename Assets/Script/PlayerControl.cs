using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    
    public float speed,mouseSpeed,forceJump, speedShot,shotx,shoty;
    public bool lockedMouse = true;
    private float mouseX = 0.0f, mouseY = 0.0f;
    public Object bullet;
    public Transform gunPlayer;
    
    void Start()
    {
        TravarMouse();
        
    }

    // Update is called once per frame
    void Update()
    {
        MoviPlayer();
        FirePlayer();
    }
    //Travar mouse no centro da tela
    void TravarMouse()
    {
        if (!lockedMouse)
        {
            return;
        }

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    //Moviemnto do Player
    void MoviPlayer()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(x, 0, z);

        //Movimento da camera
         mouseX += Input.GetAxis("Mouse X") * mouseSpeed;
         mouseY -= Input.GetAxis("Mouse Y") * mouseSpeed;

        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);

        //Pulo do Player
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, forceJump, 0);
        }
    }

    // Sistema de Tiro do Player
    void FirePlayer()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {            
            Instantiate(bullet,gunPlayer.transform.position, Quaternion.identity);
                       
        }
    }
}
