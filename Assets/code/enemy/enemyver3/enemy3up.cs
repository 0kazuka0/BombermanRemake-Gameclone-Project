using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3up : MonoBehaviour
{
    public GameObject DeathEffect;
    public GameObject Score;
    private float diry;
    public float movespeed;
    private Rigidbody2D rb;
    //private Vector3 localscale;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        diry = -1f;
        movespeed = 1.5f;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Brick")
        {
            diry *= -1f;
        }
        if (other.gameObject.tag == "B2")
        {
            diry *= -1f;
        }
        if (other.gameObject.tag == "B3")
        {
            diry *= -1f;
        }
        if (other.gameObject.tag == "B4")
        {
            diry *= -1f;
        }
        if (other.gameObject.tag == "B5")
        {
            diry *= -1f;
        }
        if (other.gameObject.tag == "B6")
        {
            diry *= -1f;
        }
        if (other.gameObject.tag == "B7")
        {
            diry *= -1f;
        }
        if (other.gameObject.tag == "B8")
        {
            diry *= -1f;
        }
        if (other.gameObject.tag == "B9")
        {
            diry *= -1f;
        }
        if (other.gameObject.tag == "B10")
        {
            diry *= -1f;

        }
        if (other.gameObject.tag == "Stone")
        {
            diry *= -1f;

        }
        if (other.gameObject.tag == "bomb")
        {
            diry *= -1f;

        }
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(rb.velocity.x, diry * movespeed);
        
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
