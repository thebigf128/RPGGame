using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horiz, vert;
    private float speed = 8f;

    [SerializeField] private Rigidbody2D rb; 

    enum Direction
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horiz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(horiz* speed, vert*speed);

        
    }
}
