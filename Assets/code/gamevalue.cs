using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamevalue : MonoBehaviour
{
    public static float hp = 2;
    public static int pause = 0;//หยุดตัวละคร
    public static int score = 0;
    public static int bombinlevel = 5;//ระเบิดฆ่าตามด่านเปลี่ยนscene
    public static int save = 0;

    public static int countenemy1 = 6;//ใช้ทุกด่าน
    public static int countenemy1timeup = 10;//ใช้ทุกด่านสำหรับตัวหมดเวลา

    public static bool stop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
