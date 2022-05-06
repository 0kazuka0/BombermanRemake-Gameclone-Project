using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cmdkill : MonoBehaviour
{
    private GameObject die;
    // Start is called before the first frame update
    void Start()
    {
        die = GameObject.Find("allenemy");
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Destroy(die);
            
        }
    }
}
