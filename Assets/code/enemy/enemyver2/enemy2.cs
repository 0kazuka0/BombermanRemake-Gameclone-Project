using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    public GameObject DeathEffect;
    public GameObject Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
