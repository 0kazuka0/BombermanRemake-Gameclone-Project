using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    public GameObject enem;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            enem.SetActive(true);
            //gamevalue.hp -= 1;
            /*Debug.Log(gamevalue.hp);
            if (gamevalue.hp >= 0)
            {
                SceneManager.LoadScene(0);
            }
            if (gamevalue.hp < 0)
            {
                SceneManager.LoadScene(1);
            }*/
            //gamevalue.countenemy1 = 10;
            //Debug.Log(gamevalue.countenemy1);
            //SceneManager.LoadScene(2);
            //gamevalue.countenemy1 = 7;
        }
    }
}