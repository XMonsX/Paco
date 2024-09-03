using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad;
    private float zPosition = 0f;
    private float zRotation = 0f;
    public SpriteRenderer spr;


    // Update is called once per frame
    void Update()
    {
        procesarmov();
        Vector3 currentPosition = transform.position;
        currentPosition.z = zPosition;
        transform.position = currentPosition;

       
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z = zRotation;
        transform.eulerAngles = currentRotation;
    }

    void procesarmov()
    {
        float move = Input.GetAxis("Horizontal");
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.velocity = new Vector2(move*velocidad, rigidbody.velocity.y);

        if (move > 0)
        {
            spr.flipX = false;
        }
        if (move < 0)
        {
            spr.flipX = true;
        }
    }
}
