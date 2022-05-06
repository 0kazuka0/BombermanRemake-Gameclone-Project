using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx : MonoBehaviour
{
    public static AudioClip Bomb, Pressbomb,Dooropen;
    static AudioSource soundsorce;
    void Start()
    {
        
        Bomb = Resources.Load<AudioClip>("Bomb");
        Pressbomb = Resources.Load<AudioClip>("Pressbomb");
        Dooropen = Resources.Load<AudioClip>("Dooropen");

        soundsorce = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void playsound(string clip)
    {
        switch(clip)
        {
            case "Bomb":
                soundsorce.PlayOneShot(Bomb);
                break;
            case "Pressbomb":
                soundsorce.PlayOneShot(Pressbomb);
                break;
            case "Dooropen":
                soundsorce.PlayOneShot(Dooropen);
                break;
        }
    }
}
