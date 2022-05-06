using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menubutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void startbut()
   {
        SceneManager.LoadScene(1);
        gamevalue.hp = 2;
        gamevalue.pause = 0;
        gamevalue.score = 0;
        gamevalue.bombinlevel = 5;
        gamevalue.stop = false;
    }
    public void exitbut()
    {
        Application.Quit();
    }
}
