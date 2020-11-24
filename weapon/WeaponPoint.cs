using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;

    public Animator parent;
    // Update is called once per frame
   public void shoot()
    {
        
            var transform1 = transform;
            parent.SetBool("IsShooting",true);
            Instantiate(bullet, transform1.position, transform1.rotation);
        


    }
}