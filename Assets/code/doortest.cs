using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doortest : MonoBehaviour
{
    [SerializeField] private float delaybeforechange = 2.5f;
    [SerializeField] private int scene;

    public GameObject[] enemy;
    private Animator anim;

    public AudioClip newtrack;
    private audiomanger theme;

    public bool isDone = false;

    void Start()
    {
        theme = FindObjectOfType<audiomanger>();
    }
    void Update()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("open", isDone);
        if (isDone == false && CheckIfAllEnemyDead())
        {
            isDone = true;
            sfx.playsound("Dooropen");
            //opendoor();
        }
        if (isDone == true)
        {
            
            //opendoor();
                
        }
    }
    public bool CheckIfAllEnemyDead()
    {
        for (int i = 0; i < enemy.Length; i++)
        {
            if (enemy[i] != null)
            {
                return false;
            }
        }
        return true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(isDone==true)
        {
            gamevalue.stop = true;
            Invoke("changescene", delaybeforechange);
            if (newtrack != null)
            {
                theme.changebgm(newtrack);
            }
            gamevalue.hp++;
            gamevalue.pause = 1;
        }
    }
    void opendoor()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("open", isDone);
    }
    void changescene()
    {
        SceneManager.LoadScene(scene);
    }
}
