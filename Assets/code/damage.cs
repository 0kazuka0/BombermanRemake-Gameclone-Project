using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    public static int FIRE_DAMAGE = 1;
    public static int ENEMY_DAMAGE = 2;

    public int source;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("yes");
            other.GetComponent<bomber2>().Damage(source);
        }
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("yes1");
            other.GetComponent<enemy>().Damage(source);
            other.GetComponent<enemy2>().Damage(source);
            
        }
        if (other.gameObject.tag == "Enemy1")
        {
            other.GetComponent<enemy>().Damage(source);
            other.GetComponent<enemy2>().Damage(source);
        }
        if (other.gameObject.tag == "Enemy2")
        {
            //other.GetComponent<enemy>().Damage(source);
            //other.GetComponent<enemy2>().Damage(source);
            other.GetComponent<enemy3up>().Damage(source);
            other.GetComponent<enemy3left>().Damage(source);
        }
        if (other.gameObject.tag == "Enemy3")
        {
            other.GetComponent<enemy>().Damage(source);
            other.GetComponent<enemy2>().Damage(source);
        }
        if (other.gameObject.tag == "Enemy4")
        {
            other.GetComponent<enemy>().Damage(source);
            other.GetComponent<enemy2>().Damage(source);
        }
    }
}
