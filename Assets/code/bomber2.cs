using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomber2 : MonoBehaviour
{
    public static bomber2 Instance;

    private bool ButtonLeft;
    private bool ButtonRight;
    private bool ButtonUp;
    private bool ButtonDown;
    private bool ButtonBomb;
    private bool ButtonDetonate;

    private int BombsAllowed;
    private int FireLength;
    //private int SpeedBoosts;
    private bool NoclipWalls;
    private bool NoclipBombs;
    private bool NoclipFire;
    private bool HasDetonator;


    private bool CanMove;
    private bool IsMoving;
    private bool InsideBomb;
    private bool InsideWall;
    private bool InsideFire;

    //AudioSource soundsrc;

    public int Direction; // <4 8^ 6> 2v

    public Transform Sensor;
    public float SensorSize = 0.7f;
    public float SensorRange = 0.4f;

    public float MoveSpeed = 2;
    public float SpeedBoostPower = 2.0f;

    public LayerMask StoneLayer;
    public LayerMask BombLayer;
    public LayerMask BrickLayer;
    public LayerMask FireLayer;

    public GameObject Bomb;
    public GameObject Bomb1;
    public GameObject Bomb2;
    public GameObject Bomb3;
    public GameObject Bomb4;

   
    public GameObject DeathEffect;
    


    public GameObject killall;
    public GameObject killall1;
    public GameObject killall2;
    public GameObject killall3;
    public GameObject killall4;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(true);
        //soundsrc = GetComponent<AudioSource>();
        gamevalue.pause = 0;
        if (gamevalue.save == 0)
        {
            BombsAllowed = 1;
            FireLength = 1;
        }
        
        if(Instance!=null)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
        GameObject.DontDestroyOnLoad(this.gameObject);     

    }
    // Update is called once per frame
    void Update()
    {
        GetInput();
        GetDirection();
        HandleSensor();
        HandleBombs();
        Move();
        autokill();

        Animate();
        /*if(gamevalue.pause==0)
        {
            if (IsMoving)
            {
                if (!soundsrc.isPlaying)
                    soundsrc.Play();
            }
            else
            {
                soundsrc.Stop();
            }
        }*/

        if(Input.GetKeyDown(KeyCode.T))
        {
            //Debug.Log(gamevalue.score);
            //Debug.Log(gamevalue.hp);
            //Debug.Log(gamevalue.countenemy1);
            Debug.Log(gamevalue.bombinlevel);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PowerUp")
        {
            switch (other.GetComponent<powerup>().Type)
            {
                // 0 - extra bomb
                // 1 - fire
                // 2 - speed
                // 3 - noclip wall
                // 4 - noclip fire
                // 5 - noclip bomb
                // 6 - detonator
                case 0:
                    GetExtraBomb();
                    break;
                case 1:
                    GetExtraFire();
                    break;
                case 2:
                    GetExtraSpeed();
                    break;
                case 3:
                    GetNoclipWalls();
                    break;
                case 4:
                    GetNoclipFire();
                    break;
                case 5:
                    GetNoclipBombs();
                    break;
                case 6:
                    GetDetonator();
                    break;
            }
            Destroy(other.gameObject);
        }

    }

    public void Damage(int source)
    {

        if (source == 2)
        {
            gamevalue.hp -= 1;
            Die();
        }
        else if (source == 1 && !NoclipFire)
        {
            gamevalue.hp -= 0.5f;
            Die();
        }        
    }

    void Die()
    {
        //gamevalue.hp -= 1;//เลือด
        Instantiate(DeathEffect, transform.position, transform.rotation);
        Destroy(gameObject);   
    }

    void GetDetonator()
    {
        HasDetonator = true;
    }

    void GetNoclipWalls()
    {
        NoclipWalls = true;
    }

    void GetNoclipBombs()
    {
        NoclipBombs = true;
    }

    void GetNoclipFire()
    {
        NoclipFire = true;
    }

    void GetExtraSpeed()
    {
        //SpeedBoosts++;
        MoveSpeed = MoveSpeed += SpeedBoostPower;
    }

    void GetExtraFire()
    {
        FireLength++;
    }

    void GetExtraBomb()
    {
        BombsAllowed++;
    }

    private void HandleBombs()
    {
        if (ButtonBomb && GameObject.FindGameObjectsWithTag("bomb").Length < BombsAllowed && !InsideBomb && !InsideFire && !InsideWall && gamevalue.bombinlevel == 5)//lv1
        {
            Instantiate(Bomb, new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y)), transform.rotation);
            sfx.playsound("Pressbomb");//เสียงวางระเบิด
            /*var enemies = FindObjectsOfType<enemy>();
            foreach (var item in enemies)
            {
                item.ReCalculatePath();
            }*/
        }
        if (ButtonBomb && GameObject.FindGameObjectsWithTag("bomb").Length < BombsAllowed && !InsideBomb && !InsideFire && !InsideWall && gamevalue.bombinlevel == 4)//lv2
        {
            Instantiate(Bomb1, new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y)), transform.rotation);
            sfx.playsound("Pressbomb");
            //var enemies = FindObjectsOfType<enemy>();
            /*foreach (var item in enemies)
            {
                item.ReCalculatePath();
            }*/
        }
        if (ButtonBomb && GameObject.FindGameObjectsWithTag("bomb").Length < BombsAllowed && !InsideBomb && !InsideFire && !InsideWall && gamevalue.bombinlevel == 3)//lv3
        {
            Instantiate(Bomb2, new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y)), transform.rotation);
            sfx.playsound("Pressbomb");
            //var enemies = FindObjectsOfType<enemy>();
            /*foreach (var item in enemies)
            {
                item.ReCalculatePath();
            }*/
        }
        if (ButtonBomb && GameObject.FindGameObjectsWithTag("bomb").Length < BombsAllowed && !InsideBomb && !InsideFire && !InsideWall && gamevalue.bombinlevel == 2)//lv4
        {
            Instantiate(Bomb3, new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y)), transform.rotation);
            sfx.playsound("Pressbomb");
            //var enemies = FindObjectsOfType<enemy>();
            /*foreach (var item in enemies)
            {
                item.ReCalculatePath();
            }*/
        }
        if (ButtonBomb && GameObject.FindGameObjectsWithTag("bomb").Length < BombsAllowed && !InsideBomb && !InsideFire && !InsideWall && gamevalue.bombinlevel==1)//lv5
        {
            Instantiate(Bomb4, new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y)), transform.rotation);
            sfx.playsound("Pressbomb");
            //var enemies = FindObjectsOfType<enemy>();
            /*foreach (var item in enemies)
            {
                item.ReCalculatePath();
            }*/
        }
        if (ButtonDetonate && HasDetonator == true) 
        {
            sfx.playsound("Bomb");
            print("det");
            var bombs = FindObjectsOfType<bomb>();
            foreach (var bomb in bombs)
            {
                bomb.Blow();
            }
        }
    }
    private void autokill()
    {
        if (Input.GetKeyDown(KeyCode.K) && gamevalue.bombinlevel == 5)
        {
            Instantiate(killall, new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y)), transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.K) && gamevalue.bombinlevel == 4)
        {
            Instantiate(killall1, new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y)), transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.K) && gamevalue.bombinlevel == 3)
        {
            Instantiate(killall2, new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y)), transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.K) && gamevalue.bombinlevel == 2)
        {
            Instantiate(killall3, new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y)), transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.K) && gamevalue.bombinlevel == 1)
        {
            Instantiate(killall4, new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y)), transform.rotation);
        }
    }

    private void Move()
    {
        if(gamevalue.pause==0)
        { 
            if (!CanMove)
            {
                IsMoving = false;
                return;
            }
            IsMoving = true;
            switch (Direction)
            {
                case 2:
                    transform.position = new Vector2(Mathf.Round(transform.position.x), transform.position.y - MoveSpeed * Time.deltaTime);
                    break;
                case 4:
                    transform.position = new Vector2(transform.position.x - MoveSpeed * Time.deltaTime, Mathf.Round(transform.position.y));
                    GetComponent<SpriteRenderer>().flipX = false;
                    break;
                case 6:
                    transform.position = new Vector2(transform.position.x + MoveSpeed * Time.deltaTime, Mathf.Round(transform.position.y));
                    GetComponent<SpriteRenderer>().flipX = true;
                    break;
                case 8:
                    transform.position = new Vector2(Mathf.Round(transform.position.x), transform.position.y + MoveSpeed * Time.deltaTime);
                    break;
                case 5:
                    IsMoving = false;
                    break;
            }
        }

    }

    void HandleSensor()
    {
        Sensor.transform.localPosition = new Vector2(0, 0);
        InsideWall = Physics2D.OverlapBox(Sensor.position, new Vector2(SensorSize, SensorSize), 0, BrickLayer);
        InsideBomb = Physics2D.OverlapBox(Sensor.position, new Vector2(SensorSize, SensorSize), 0, BombLayer);
        InsideFire = Physics2D.OverlapBox(Sensor.position, new Vector2(SensorSize, SensorSize), 0, FireLayer);
        switch (Direction)
        {
            case 2:
                Sensor.transform.localPosition = new Vector2(0, -SensorRange);
                break;
            case 4:
                Sensor.transform.localPosition = new Vector2(-SensorRange, 0);
                break;
            case 6:
                Sensor.transform.localPosition = new Vector2(SensorRange, 0);
                break;
            case 8:
                Sensor.transform.localPosition = new Vector2(0, SensorRange);
                break;
        }
        CanMove = !Physics2D.OverlapBox(Sensor.position, new Vector2(SensorSize, SensorSize), 0, StoneLayer);
        if (CanMove)
        {
            if (!NoclipWalls)
                CanMove = !Physics2D.OverlapBox(Sensor.position, new Vector2(SensorSize, SensorSize), 0, BrickLayer);
        }
        if (CanMove && !InsideBomb)
        {
            if (!NoclipBombs)
                CanMove = !Physics2D.OverlapBox(Sensor.position, new Vector2(SensorSize, SensorSize), 0, BombLayer);
        }

    }

    void GetDirection()
    {
        Direction = 5;
        if (ButtonLeft) Direction = 4;
        if (ButtonRight) Direction = 6;
        if (ButtonUp) Direction = 8;
        if (ButtonDown) Direction = 2;
    }

    public bool CheckDetonator()
    {
        return HasDetonator;
    }

    void GetInput()
    {
        if (gamevalue.pause == 0)//เดินได้
        {
            ButtonLeft = Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow);
            ButtonRight = !Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow);
            ButtonUp = !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow);
            ButtonDown = !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.DownArrow);

            ButtonBomb = Input.GetKeyDown(KeyCode.Z);
            ButtonDetonate = Input.GetKeyDown(KeyCode.X);
        }
    }

    public void AddBomb()
    {
        BombsAllowed++;
    }

    public void AddFireLenght()
    {
        FireLength++;
    }

    public int GetFireLength()
    {
        return FireLength;
    }

    void Animate()
    {
        var animator = GetComponent<Animator>();
        if (gamevalue.pause == 0)//เดินได้
        {
            animator.SetInteger("Direction", Direction);
            animator.SetBool("Moving", IsMoving);
            animator.SetBool("pause", false);
        }
        if(gamevalue.pause==1)
        {
            animator.SetInteger("Direction", 5);
            animator.SetBool("pause", true);
        }
    }

}
