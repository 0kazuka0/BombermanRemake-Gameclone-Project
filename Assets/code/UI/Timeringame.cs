using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timeringame : MonoBehaviour
{
    public  int countdownvalue = 200;
    public Text timerui;

    public GameObject enemycommon;
    public GameObject enemytumeup;
    public GameObject door1;
    public GameObject door2;
    //public static bool stop;
    // Start is called before the first frame update
    void Start()
    {
        countdowntimer();
        door1.SetActive(true);
        enemycommon.SetActive(true);
        enemytumeup.SetActive(false);
        door2.SetActive(false);
        
    }
    void countdowntimer()
    {
        if(countdownvalue>0&&gamevalue.stop==false)
        {
            timerui.text = "Time  " + countdownvalue;
            countdownvalue--;
            Invoke("countdowntimer", 1.0f);
           
        }
        else if(countdownvalue <= 0 && gamevalue.stop == false)
        {
            timerui.text = "Time  0";
            enemycommon.SetActive(false);
            enemytumeup.SetActive(true);
            door1.SetActive(false);
            door2.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
