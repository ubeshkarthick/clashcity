using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody drigidbody;
    public float speed = 10f;
    public float turningspeed;
    public float horizontalinput;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalinput = Input.GetAxisRaw("Horizontal");
    }
    void FixedUpdate()
    {
        Vector3 forwardmove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalmove = transform.right * horizontalinput * Time.fixedDeltaTime * turningspeed;
        drigidbody.MovePosition(drigidbody.position + forwardmove + horizontalmove);
    }

}
