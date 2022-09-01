using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crab : MonoBehaviour
{

    public Transform groundPos;
    public float speed;
    public LayerMask groundLayer;
    public float rad;


    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        patrol();
    }

    void patrol()
    {
        rb.velocity = new Vector2(speed, 0f);

        bool isgrounded = Physics2D.OverlapCircle(groundPos.position, rad, groundLayer);
        if (isgrounded)
        {
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            speed += -1;
        }
    }
}
