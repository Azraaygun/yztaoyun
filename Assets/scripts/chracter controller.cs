using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class chractercontroller : MonoBehaviour

{
    public float speed = 0.0f;
    private Rigidbody2D r2d;
    private Animator animator;

    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            speed = 1.0f;
            Debug.Log(message: "hiz 1.0f");
        }
        else
        {
            speed = 0.0f;
            Debug.Log(message: "hiz 0.0f");
        }

       animator.SetFloat("speed", speed);
        r2d.velocity = new Vector2(x:speed, y:0f);

    }
}