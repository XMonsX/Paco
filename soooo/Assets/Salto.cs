using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    public Rigidbody2D rbd;
    public float fuerza;
    public Transform groundCheck; 
    public float groundCheckRadius; 
    public LayerMask whatIsGround; 

    private bool Suelo;

    void Start()
    {
        
    }

    void Update()
    {
        Suelo = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && Suelo)
        {
            rbd.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
        }
    }
}
