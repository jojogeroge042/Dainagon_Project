using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    // 左矢印が押されたとき
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0); //左に3動かす
    }
    // 右矢印が押されたとき
    public void RButtoneDown()
    {
        transform.Translate(3, 0, 0); //右に3動かす
    }
}
