using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class loadscenedelay : MonoBehaviour
{
    [SerializeField] private float delaybeforechange = 4f;
    [SerializeField] private int scene;
    private float time;
    
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time>delaybeforechange)
        {
            SceneManager.LoadScene(scene);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            gamevalue.pause = 1;//player can move
            gamevalue.stop = false;
        }
    }
}
