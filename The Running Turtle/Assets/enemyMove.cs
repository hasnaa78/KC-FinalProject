using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public float speed;
    public bool moveright;
    public Transform groundPos;
    public float speed1;
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
        //if move right bool is true maen he will move to the left
        if (moveright)
        {
            transform.Translate(1 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(1, 1);
        }
        else 
        {
            transform.Translate(-1 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-1, 1);
        }
    }


    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("turn"))
        {
            if (moveright)
            {
                moveright = true;
            }
            else
            {
                moveright = false;    
            }
        }
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
