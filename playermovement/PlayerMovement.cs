using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D player;
    private Animator _animator;
    public CharacterController2D Controller2D;
    public float speed;
    public Joystick Joystick;
    private float move = 0f;
    private Boolean jump = false;
    private Boolean fire = false;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Joystick.Horizontal;
        
        _animator.SetFloat("speed",Math.Abs(move));
        
        //
        // if (Input.GetButtonDown("Fire1"))
        // {
        //     fire = true;
        //     _animator.SetBool("IsShooting",true);
        //
        // }
        // else if(Input.GetButtonUp("Fire1"))
        // {
        //     fire = false;
        //     _animator.SetBool("IsShooting",false);
        //     
        // }

    }

    public void Jump()
    {
        jump = true;
        _animator.SetBool("IsJumping",true);
    }
	

    public void OnLand() 
    {
        _animator.SetBool("IsJumping",false); 
        Debug.Log("onLand");
    }


    private void FixedUpdate()
    {
        Controller2D.Move(move*Time.deltaTime*speed,false,jump); ;
        jump = false;


    }
}
