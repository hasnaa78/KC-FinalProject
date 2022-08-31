using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;
    public bool moveright;
    // Update is called once per frame
    void Update()
    {
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
}