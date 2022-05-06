using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blv5 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gamevalue.bombinlevel = 1;
            gamevalue.pause = 0;
            
        }
    }
}

