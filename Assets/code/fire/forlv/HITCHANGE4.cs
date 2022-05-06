using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HITCHANGE4 : MonoBehaviour
{
    [SerializeField] private float delaybeforechange = 5f;
    [SerializeField] private int scene;
    private bool isdone;

    public AudioClip newtrack;
    private audiomanger theme;

    void Start()
    {
        theme = FindObjectOfType<audiomanger>();
    }
    private void OnTriggerEnter2D(Collider2D other)//ใส่ระเบิดกับMonster
    {
        if (other.gameObject.tag == "Player")
        {

            if (gamevalue.hp >= 0)
            {
                if (newtrack != null)
                {
                    theme.changebgm(newtrack);
                }
                Invoke("changescene", delaybeforechange);
            }
            if (gamevalue.hp < 0)
            {
                if (newtrack != null)
                {
                    theme.changebgm(newtrack);
                }
                Invoke("gameover", delaybeforechange);
            }

            //SceneManager.LoadScene(3);
            //other.gameObject.SetActive(true);
        }
    }
    void changescene()
    {
        SceneManager.LoadScene(scene);
    }
    void gameover()
    {
        SceneManager.LoadScene(11);
    }
}
