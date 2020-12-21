using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    private Rigidbody2D _rigidbody2D;
    

    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.velocity = transform.right * speed;
        _animator = GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit");
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("boom");
        _animator.SetBool("Hit",true);
        Destroy(gameObject,0.2f);
    }
}
