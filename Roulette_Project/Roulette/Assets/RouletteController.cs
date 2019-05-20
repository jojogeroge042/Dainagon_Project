using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; //回転速度
    System.Random r_num1 = new System.Random(1000);
    System.Random r_num2 = new System.Random(1000);
    int num1 = 0;
    int num2 = 0;

    void Start()
    {
        
    }

    void Update()
    {
        //マウスが押されたら回転速度を設定する
        if (Input.GetMouseButtonDown(0))
        {
            this.num1 = this.r_num1.Next(1000);
            this.num2 = this.r_num2.Next(1000);
            this.rotSpeed = num1 + num2;
            // 音を鳴らす
            GetComponent<AudioSource>().Play();
        }

        //回転速度分、ルーレットを回転させる
        transform.Rotate(0, 0, this.rotSpeed);

        this.rotSpeed *= 0.96f;
    }
}
