using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    Text getlife;
    
    // Start is called before the first frame update
    void Start()
    {
        getlife = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gamevalue.hp >= 0)
        {
            getlife.text = "LEFT  " + gamevalue.hp;
        }
        else
        {
            getlife.text = "LEFT  " +0;
        }
    }
    
}
