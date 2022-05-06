using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3left : MonoBehaviour
{
    public GameObject DeathEffect;
    public GameObject Score;
    private float dirx;
    public float movespeed;
    private Rigidbody2D rb;
    //private Vector3 localscale;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dirx = -1f;
        movespeed = 1.5f;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
      
        if (other.gameObject.tag == "Brick")
        {
            dirx *= -1f;
        }
        if (other.gameObject.tag == "B2")
        {
            dirx *= -1f;
        }
        if (other.gameObject.tag == "B3")
        {
            dirx *= -1f;
        }
        if (other.gameObject.tag == "B4")
        {
            dirx *= -1f;
        }
        if (other.gameObject.tag == "B5")
        {
            dirx *= -1f;
        }
        if (other.gameObject.tag == "B6")
        {
            dirx *= -1f;
        }
        if (other.gameObject.tag == "B7")
        {
            dirx *= -1f;
        }
        if (other.gameObject.tag == "B8")
        {
            dirx *= -1f;
        }
        if (other.gameObject.tag == "B9")
        {
            dirx *= -1f;
        }
        if (other.gameObject.tag == "B10")
        {
            dirx *= -1f;

        }
        if (other.gameObject.tag == "Stone")
        {
            dirx *= -1f;

        }
        if (other.gameObject.tag == "bomb")
        {
            dirx *= -1f;

        }
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirx * movespeed, rb.velocity.y);
    }
    public void Damage(int source)
    {
        if (source == 1)
        {
            Instantiate(DeathEffect, transform.position, transform.rotation);
            Instantiate(Score, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
