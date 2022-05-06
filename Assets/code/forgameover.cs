using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forgameover : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            gamevalue.hp = 2;
            gamevalue.score = 0;
            gamevalue.bombinlevel = 5;
            Destroy(collision.gameObject);
            Debug.Log(gamevalue.hp);
            Debug.Log(gamevalue.score);
            Debug.Log(gamevalue.bombinlevel);
        }
    }
}
