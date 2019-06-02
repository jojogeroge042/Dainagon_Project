using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player"); // Playerを探してオブジェクト化
    }

    // Update is called once per frame
    void Update()
    {
        //フレームごとに等間隔で落下させる
        transform.Translate(0, -0.1f, 0);

        //　画面を出たらオブジェクトを破壊する。
        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //　当たり判定
        Vector2 p1 = transform.position; // 矢印の中心座標
        Vector2 p2 = this.player.transform.position; //　プレーヤの中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f; //矢印の半径
        float r2 = 1.0f; //プレーヤの半径

        if(d < r1 + r2)
        {
            // 監督スクリプトにプレーヤと衝突したことを伝える
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();

            //衝突した矢印を消す
            Destroy(gameObject);
        }
    }
}
