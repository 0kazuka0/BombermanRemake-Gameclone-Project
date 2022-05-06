using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blv2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gamevalue.bombinlevel = 4;
            gamevalue.pause = 0;
            
        }
    }
}

