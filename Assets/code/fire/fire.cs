using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
   
    public GameObject BrickDeathEffect;
    public GameObject BrickDeathEffect2;
    public GameObject BrickDeathEffect3;
    public GameObject BrickDeathEffect4;
    public GameObject BrickDeathEffect5;
    public GameObject BrickDeathEffect6;
    public GameObject BrickDeathEffect7;
    public GameObject BrickDeathEffect8;
    public GameObject BrickDeathEffect9;
    public GameObject BrickDeathEffect10;

   

    public void DestroySelf()
    {
        //Destroy(gameObject);
        this.gameObject.SetActive(false);
    }
    

    void OnCollisionEnter2D(Collision2D other)
    {
      
        if (other.gameObject.tag == "Brick")
        {
            Debug.Log("done");
            Destroy(other.gameObject);
            Instantiate(BrickDeathEffect, transform.position, transform.rotation);
        }
        if (other.gameObject.tag == "B2")
        {
            Destroy(other.gameObject);
            Instantiate(BrickDeathEffect2, transform.position, transform.rotation);
        }
        if (other.gameObject.tag == "B3")
        {
            Destroy(other.gameObject);
            Instantiate(BrickDeathEffect3, transform.position, transform.rotation);
        }
        if (other.gameObject.tag == "B4")
        {
            Destroy(other.gameObject);
            Instantiate(BrickDeathEffect4, transform.position, transform.rotation);
        }
        if (other.gameObject.tag == "B5")
        {
            Destroy(other.gameObject);
            Instantiate(BrickDeathEffect5, transform.position, transform.rotation);
        }
        if (other.gameObject.tag == "B6")
        {
            Destroy(other.gameObject);
            Instantiate(BrickDeathEffect6, transform.position, transform.rotation);
        }
        if (other.gameObject.tag == "B7")
        {
            Destroy(other.gameObject);
            Instantiate(BrickDeathEffect7, transform.position, transform.rotation);
        }
        if (other.gameObject.tag == "B8")
        {
            Destroy(other.gameObject);
            Instantiate(BrickDeathEffect8, transform.position, transform.rotation);
        }
        if (other.gameObject.tag == "B9")
        {
            Destroy(other.gameObject);
            Instantiate(BrickDeathEffect9, transform.position, transform.rotation);
        }
        if (other.gameObject.tag == "B10")
        {
            Destroy(other.gameObject);
            Instantiate(BrickDeathEffect10, transform.position, transform.rotation);

        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            
            gamevalue.score += 100;//100
            gamevalue.countenemy1 -= 1;
            
        }
        if (other.gameObject.tag == "Enemy1")
        {
            gamevalue.score += 200;
            gamevalue.countenemy1 -= 1;
        }
        if (other.gameObject.tag == "Enemy2")
        {
            gamevalue.score += 400;
            gamevalue.countenemy1 -= 1;
        }
        if (other.gameObject.tag == "Enemy3")
        {
            gamevalue.score += 800;
            gamevalue.countenemy1 -= 1;
        }
        if (other.gameObject.tag == "Enemy4")
        {
            gamevalue.score += 8000;
            gamevalue.countenemy1timeup -= 1;
        }
    }

}
