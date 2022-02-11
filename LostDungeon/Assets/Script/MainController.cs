using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public Animator animator;
    public Rigidbody rigibody;

    private float h;
    private float v;

    private float moveX;
    private float moveZ;
    private float speedH = 100f;
    private float speedZ = 160f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            animator.Play("JUMP00", -1, 0);

        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        animator.SetFloat("h", h);
        animator.SetFloat("v", v);

        moveX = h * speedH * Time.deltaTime;
        moveZ = v * speedZ * Time.deltaTime;



      //  rigibody.velocity = new Vector3(moveX, 0, moveZ);
    }
}
