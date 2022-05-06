using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private bool opendoor;
    private Animator Anim;
    private void Start()
    {
        Anim = GetComponent<Animator>();
        
    }
    // Start is called before the first frame update
    private void Update()
    {
        if (opendoor==false) 
        {
            opendoor = true;
            Anim.SetBool("opendoor", opendoor);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (opendoor == true)
        {
            if (other.gameObject.tag == "Player")
            {
                SceneManager.LoadScene(1);
                gamevalue.bombinlevel = 4;//bombด่าน2

            }
        }
    }
 
}
