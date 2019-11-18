using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 直前の位置を記録する。
public class R_03_BU : MonoBehaviour
{
    public static Vector3 vector3 = new Vector3();
}

// このキューブの動作をコントロールする。
public class R_03_Controll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    //　衝突したときの動作判定
    void OnTriggerEnter(Collider other)
    {
        //　自操作時、敵キューブと衝突したとき
        if ((Cube_Status.Status_R_03 == true) && (other.gameObject.tag == "Blue_Cube"))
        {
          if(Game_Status.Kill == false)
          {
            // 敵キューブが二段積ではない場合。
            if (other.gameObject.transform.localScale.y < 0.5f)
            {
                // 相手キューブを削除
                Destroy(other.gameObject);
                // キルステータスを更新
                Game_Status.Kill = true;
                // 自キューブのステータスをアイドルにする。
                Cube_Status.Status_R_03 = false;
                // 奇数偶数ステータスをfalseにする
                Cube_Status.OddEven_Cube[Define.R_03] = false;
                // エフェクトを切る
                GetComponent<ParticleSystem>().Stop();
            }
            // 敵キューブが二段積みの場合
            else
            {
                // 相手キューブが最奥ではない場合
                if (other.gameObject.transform.position.x - 1 > -4)
                {
                    Vector3 Vec = new Vector3(other.gameObject.transform.position.x -1, 0f, other.gameObject.transform.position.z);
                    bool Check_Value = false;
                    int i = 0;
                    // 後ろに駒があるかチェック
                    for (i = 0; i < 22; i++)
                    {
                      if (Vec == Cube_Location.Cube_Loc[i])
                      {
                          Check_Value = true;
                      }
                    }

                    if (true == Check_Value)
                    {
                      // 相手キューブを削除
                      Destroy(other.gameObject);
                      // キルステータスを更新
                      Game_Status.Kill = true;
                      // 自キューブのステータスをアイドルにする。
                      Cube_Status.Status_R_03 = false;
                      // 奇数偶数ステータスをfalseにする
                      Cube_Status.OddEven_Cube[Define.R_03] = false;
                      // エフェクトを切る
                      GetComponent<ParticleSystem>().Stop();
                    }
                    else
                    {
                       // 敵キューブを1つ後ろに後退
                       other.gameObject.transform.position = new Vector3(other.gameObject.transform.position.x -1, 0f, other.gameObject.transform.position.z);
                       // 敵キューブのサイズをもとに戻す
                       other.gameObject.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
                       // キルステータスを更新
                       Game_Status.Kill = true;
                       // 自キューブのステータスをアイドルにする。
                       Cube_Status.Status_R_03 = false;
                      // 奇数偶数ステータスをfalseにする
                      Cube_Status.OddEven_Cube[Define.R_03] = false;
                       // エフェクトを切る
                       GetComponent<ParticleSystem>().Stop();
                    }
                }
                else
                {
                    // 相手キューブを削除
                    Destroy(other.gameObject);
                    // キルステータスを更新
                    Game_Status.Kill = true;
                    // 自キューブのステータスをアイドルにする。
                    Cube_Status.Status_R_03 = false;
                    // 奇数偶数ステータスをfalseにする
                    Cube_Status.OddEven_Cube[Define.R_03] = false;
                    // エフェクトを切る
                    GetComponent<ParticleSystem>().Stop();
                } // End of 最奥チェック
            } // End of 2段積みの場合
          }
          else
          {
            // 元の位置に戻す
            transform.position = R_03_BU.vector3;
            if (Dice_Status.Count == 0)
            {
              GetComponent<ParticleSystem>().Play();
            }
            Dice_Status.Count += 1;
          }
        }
        // 味方キューブの場合
        else if ((Cube_Status.Status_R_03 == true) && (other.gameObject.tag == "Red_Cube"))
        {
            // 自キューブが二段積みではない場合
            if (transform.localScale.y < 0.5f)
            {
                // 衝突先の味方キューブが二段積みではない場合
                if (other.gameObject.transform.localScale.y < 0.5f)
                {
                    // 衝突先のキューブを削除
                    Destroy(other.gameObject);
                    // 高さを二段に変更
                    this.transform.localScale = new Vector3(0.25f, 0.5f, 0.25f);
                    // 自キューブのステータスをアイドルにする。
                    Cube_Status.Status_R_03 = false;
                    // 奇数偶数ステータスをfalseにする
                    Cube_Status.OddEven_Cube[Define.R_03] = false;
                    // エフェクトを切る
                    GetComponent<ParticleSystem>().Stop();
                }
                else
                {
                    transform.position = R_03_BU.vector3;
                    if (Dice_Status.Count == 0)
                    {
                      GetComponent<ParticleSystem>().Play();
                    }
                    Dice_Status.Count += 1;
                }
            }
            else
            {
                transform.position = R_03_BU.vector3;
                if (Dice_Status.Count == 0)
                {
                  GetComponent<ParticleSystem>().Play();
                }
                Dice_Status.Count += 1;
            }
        }
    } // End of On trigger Enter

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);

                float Local_x = transform.localPosition.x;
                float Local_z = transform.localPosition.z;


                if (Cube_Status.Status_R_03 == true)
                {
                    if ((((Local_x - x) == 0) && ((Local_z - z) == 1))
                      || (((Local_x - x) == 0) && ((Local_z - z) == -1))
                        || (((Local_x - x) == 1) && ((Local_z - z) == 0))
                          || (((Local_x - x) == -1) && ((Local_z - z) == 0)))
                    {
                        R_03_BU.vector3 = transform.position;
                        transform.position = new Vector3(x, 0, z);
                        GetComponent<AudioSource>().Play();
                        Dice_Status.Count -= 1;
                    }
                }

            } // if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        } //  End of if (Input.GetMouseButtonDown(0))

        Cube_Location.Cube_Loc[Define.R_03] = transform.position;
        
        if (Dice_Status.Count == 0)
        {
          GetComponent<ParticleSystem>().Stop();
        }  
    }
}
