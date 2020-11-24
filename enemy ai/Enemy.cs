using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    private Boolean movingLeft = true;
    public float speed;
    public Transform groundCheck;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * (speed * Time.deltaTime));
        RaycastHit2D groundUInfo = Physics2D.Raycast(groundCheck.position, Vector2.down, 5f);
        if (groundUInfo.collider==false)
        {
            if (movingLeft)
            {
                transform.eulerAngles = new Vector3(0,-180,0);
                movingLeft = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0,0,0);
                movingLeft = true;
            }
            
        }

    }
}
