using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// ---------------------------------------------------------------
// - Game_Status ゲーム全体のフラグ関連のクラス
// ---------------------------------------------------------------
public class Game_Status : MonoBehaviour
{
    public static bool Turn = false;
    public static bool OnTrigger_Check = false;
    public static bool Kill = false;
}

// ---------------------------------------------------------------
// - Dice_Status 画面表示用のサイコロのステータス関連のクラス
// ---------------------------------------------------------------
public class Dice_Status : MonoBehaviour
{
    public static int B_DICE_01 = 0;
    public static int B_DICE_02 = 0;
    public static int R_DICE_01 = 0;
    public static int R_DICE_02 = 0;
    public static int Count = 0xFF;
    public static int Used_Dice = 0xFF;
}

// ---------------------------------------------------------------
// - Cube_Location キューブの位置情報クラス
// ---------------------------------------------------------------
public class Cube_Location : MonoBehaviour
{
    public static Vector3[] Cube_Loc = new Vector3[22];
}

// ---------------------------------------------------------------
// - Desine 固定値クラス
// ---------------------------------------------------------------
public class Define : MonoBehaviour
{
    public const bool Red_Turn = true;
    public const bool Blue_Turn = false;
    public const int DICE_B01 = 0;
    public const int DICE_B02 = 1;
    public const int DICE_R01 = 2;
    public const int DICE_R02 = 3;
    public const int B_00 = 0;
    public const int B_01 = 1;
    public const int B_02 = 2;
    public const int B_03 = 3;
    public const int B_04 = 4;
    public const int B_05 = 5;
    public const int B_06 = 6;
    public const int B_07 = 7;
    public const int B_08 = 8;
    public const int B_09 = 9;
    public const int B_10 = 10;
    public const int R_00 = 11;
    public const int R_01 = 12;
    public const int R_02 = 13;
    public const int R_03 = 14;
    public const int R_04 = 15;
    public const int R_05 = 16;
    public const int R_06 = 17;
    public const int R_07 = 18;
    public const int R_08 = 19;
    public const int R_09 = 20;
    public const int R_10 = 21;
    public static Vector3[] Location_odd =  new Vector3 [17];
    public static Vector3[] Location_even =  new Vector3 [18];


}
// ---------------------------------------------------------------
// - Cube_Status キューブの稼働可能かのステータスを示すクラス
// ---------------------------------------------------------------
public class Cube_Status : MonoBehaviour
{
    public static bool Status_B_00 = false;
    public static bool Status_B_01 = false;
    public static bool Status_B_02 = false;
    public static bool Status_B_03 = false;
    public static bool Status_B_04 = false;
    public static bool Status_B_05 = false;
    public static bool Status_B_06 = false;
    public static bool Status_B_07 = false;
    public static bool Status_B_08 = false;
    public static bool Status_B_09 = false;
    public static bool Status_B_10 = false;
    public static bool Status_R_00 = false;
    public static bool Status_R_01 = false;
    public static bool Status_R_02 = false;
    public static bool Status_R_03 = false;
    public static bool Status_R_04 = false;
    public static bool Status_R_05 = false;
    public static bool Status_R_06 = false;
    public static bool Status_R_07 = false;
    public static bool Status_R_08 = false;
    public static bool Status_R_09 = false;
    public static bool Status_R_10 = false;
    public static bool[] OddEven_Cube = new bool[22];
    public static bool[] Double_Cube = new bool[22];
}

// ---------------------------------------------------------------
// - Cube_Controller キューブ及び、ゲームの操作のクラス
// ---------------------------------------------------------------
public class Cube_Controller : MonoBehaviour
{
    // Game Object; キューブ
    GameObject CUBE_B00;
    GameObject CUBE_B01;
    GameObject CUBE_B02;
    GameObject CUBE_B03;
    GameObject CUBE_B04;
    GameObject CUBE_B05;
    GameObject CUBE_B06;
    GameObject CUBE_B07;
    GameObject CUBE_B08;
    GameObject CUBE_B09;
    GameObject CUBE_B10;
    GameObject CUBE_R00;
    GameObject CUBE_R01;
    GameObject CUBE_R02;
    GameObject CUBE_R03;
    GameObject CUBE_R04;
    GameObject CUBE_R05;
    GameObject CUBE_R06;
    GameObject CUBE_R07;
    GameObject CUBE_R08;
    GameObject CUBE_R09;
    GameObject CUBE_R10;
    // Game Object; さいころ（テキスト）
    GameObject DICE_B01;
    GameObject DICE_B02;
    GameObject DICE_R01;
    GameObject DICE_R02;
    // Game Object; テキスト
    GameObject Game_Turn;
    GameObject Dice_Count;
    GameObject Advice;
    GameObject Sound_001;

　　　　// ---------------------------------------------------------------
　　　　// - Start　初期化処理
　　　　// ---------------------------------------------------------------
    void Start()
    {
      // オブジェクトの実体化: キューブ
      this.CUBE_B00 = GameObject.Find("B_00");
      this.CUBE_B01 = GameObject.Find("B_01");
      this.CUBE_B02 = GameObject.Find("B_02");
      this.CUBE_B03 = GameObject.Find("B_03");
      this.CUBE_B04 = GameObject.Find("B_04");
      this.CUBE_B05 = GameObject.Find("B_05");
      this.CUBE_B06 = GameObject.Find("B_06");
      this.CUBE_B07 = GameObject.Find("B_07");
      this.CUBE_B08 = GameObject.Find("B_08");
      this.CUBE_B09 = GameObject.Find("B_09");
      this.CUBE_B10 = GameObject.Find("B_10");
      this.CUBE_R00 = GameObject.Find("R_00");
      this.CUBE_R01 = GameObject.Find("R_01");
      this.CUBE_R02 = GameObject.Find("R_02");
      this.CUBE_R03 = GameObject.Find("R_03");
      this.CUBE_R04 = GameObject.Find("R_04");
      this.CUBE_R05 = GameObject.Find("R_05");
      this.CUBE_R06 = GameObject.Find("R_06");
      this.CUBE_R07 = GameObject.Find("R_07");
      this.CUBE_R08 = GameObject.Find("R_08");
      this.CUBE_R09 = GameObject.Find("R_09");
      this.CUBE_R10 = GameObject.Find("R_10");
      // オブジェクトの実体化: さいころ（テキスト）
      this.DICE_B01 = GameObject.Find("D_B_DICE01");
      this.DICE_B02 = GameObject.Find("D_B_DICE02");
      this.DICE_R01 = GameObject.Find("D_R_DICE01");
      this.DICE_R02 = GameObject.Find("D_R_DICE02");
      // オブジェクトの実体化: テキスト
      this.Game_Turn = GameObject.Find("Disp_Turn");
      this.Dice_Count = GameObject.Find("Disp_Count");
      this.Advice = GameObject.Find("Disp_Advice");
      // さいころに初期値を入れる
      this.DICE_B01.GetComponent<Text>().text = Dice_Status.B_DICE_01.ToString();
      this.DICE_B02.GetComponent<Text>().text = Dice_Status.B_DICE_02.ToString();
      this.DICE_R01.GetComponent<Text>().text = Dice_Status.R_DICE_01.ToString();
      this.DICE_R02.GetComponent<Text>().text = Dice_Status.R_DICE_02.ToString();
      // 音源1
      this.Sound_001 = GameObject.Find("Turn_Change");

      // 奇数偶数の初期化
      Define.Location_odd[0] = new Vector3(-3, 0, 1);
      Define.Location_odd[1] = new Vector3(-3, 0, -1);
      Define.Location_odd[2] = new Vector3(-2, 0, 2);
      Define.Location_odd[3] = new Vector3(-2, 0, 0);
      Define.Location_odd[4] = new Vector3(-2, 0, -2);
      Define.Location_odd[5] = new Vector3(-1, 0, 1);
      Define.Location_odd[6] = new Vector3(-1, 0, -1);
      Define.Location_odd[7] = new Vector3(0, 0, 2);
      Define.Location_odd[8] = new Vector3(0, 0, 0);
      Define.Location_odd[9] = new Vector3(0, 0, -2);
      Define.Location_odd[10] = new Vector3(1, 0, 1);
      Define.Location_odd[11] = new Vector3(1, 0, -1);
      Define.Location_odd[12] = new Vector3(2, 0, 2);
      Define.Location_odd[13] = new Vector3(2, 0, 0);
      Define.Location_odd[14] = new Vector3(2, 0, -2);
      Define.Location_odd[15] = new Vector3(3, 0, 1);
      Define.Location_odd[16] = new Vector3(3, 0, -1);

      Define.Location_even[0] = new Vector3(-3, 0, 2);
      Define.Location_even[1] = new Vector3(-3, 0, 0);
      Define.Location_even[2] = new Vector3(-3, 0, -2);
      Define.Location_even[3] = new Vector3(-2, 0, 1);
      Define.Location_even[4] = new Vector3(-2, 0, -1);
      Define.Location_even[5] = new Vector3(-1, 0, 2);
      Define.Location_even[6] = new Vector3(-1, 0, 0);
      Define.Location_even[7] = new Vector3(-1, 0, -2);
      Define.Location_even[8] = new Vector3(0, 0, 1);
      Define.Location_even[9] = new Vector3(0, 0, -1);
      Define.Location_even[10] = new Vector3(1, 0, 2);
      Define.Location_even[11] = new Vector3(1, 0, 0);
      Define.Location_even[12] = new Vector3(1, 0, -2);
      Define.Location_even[13] = new Vector3(2, 0, 1);
      Define.Location_even[14] = new Vector3(2, 0, -1);
      Define.Location_even[15] = new Vector3(3, 0, 2);
      Define.Location_even[16] = new Vector3(3, 0, 0);
      Define.Location_even[17] = new Vector3(3, 0, -2);
    }


    public void Odd_check()
    {
      int i;
      int j;
      for (i = 0; i < 22; i++)
      {
        for (j = 0; j < 17; j++)
        {
          if (Cube_Location.Cube_Loc[i] == Define.Location_odd[j])
          {
            Cube_Status.OddEven_Cube[i] = true;
          }
        }
      }
    }

    public void Even_Check()
    {
      int i;
      int j;
      for (i = 0; i < 22; i++)
      {
        for (j = 0; j < 18; j++)
        {
          if (Cube_Location.Cube_Loc[i] == Define.Location_even[j])
          {
            Cube_Status.OddEven_Cube[i] = true;
          }
        }
      }
    }

    public void OddEven_Cube_Enable()
    {
      int i;
      for (i = 0; i < 22; i++)
      {
        Cube_Status.OddEven_Cube[i] = true;
      }
    }

　　　　// ---------------------------------------------------------------
　　　　// - Use_Dice_B01 さいころ　B_00の値をカウントに入れる
　　　　// ---------------------------------------------------------------
    public void Use_Dice_B01()
    {
      Dice_Status.Count = Dice_Status.B_DICE_01;
      Dice_Status.Used_Dice = Define.DICE_B01;
      this.Dice_Count.GetComponent<Text>().text = "残り : " + Dice_Status.Count.ToString();
      this.DICE_B01.GetComponent<Text>().text ="X";

      if(Dice_Status.B_DICE_01 == 1)
      {
        this.Advice.GetComponent<Text>().text ="どのマスの駒でも移動可能だよ！";
        OddEven_Cube_Enable();
      }
      else if(Dice_Status.B_DICE_01 % 2 ==1)
      {
        this.Advice.GetComponent<Text>().text ="ターン開始時に白マスの駒が移動可能だよ！";
        Odd_check();
      }
      else
      {
        this.Advice.GetComponent<Text>().text ="ターン開始時に黒マスの駒が移動可能だよ！";
        Even_Check();
      }
    }

    public void Use_Dice_B02()
    {
      Dice_Status.Count = Dice_Status.B_DICE_02;
      Dice_Status.Used_Dice = Define.DICE_B02;
      this.Dice_Count.GetComponent<Text>().text = "残り : " + Dice_Status.Count.ToString();
      this.DICE_B02.GetComponent<Text>().text ="X";

      if(Dice_Status.B_DICE_02 == 1)
      {
        this.Advice.GetComponent<Text>().text ="どのマスの駒でも移動可能だよ！";
        OddEven_Cube_Enable();
      }
      else if(Dice_Status.B_DICE_02 % 2 ==1)
      {
        this.Advice.GetComponent<Text>().text ="ターン開始時に白マスの駒が移動可能だよ！";
        Odd_check();
      }
      else
      {
        this.Advice.GetComponent<Text>().text ="ターン開始時に黒マスの駒が移動可能だよ！";
        Even_Check();
      }
    }

    public void Use_Dice_R01()
    {
      Dice_Status.Count = Dice_Status.R_DICE_01;
      Dice_Status.Used_Dice = Define.DICE_R01;
      this.Dice_Count.GetComponent<Text>().text = "残り : " + Dice_Status.Count.ToString();
      this.DICE_R01.GetComponent<Text>().text ="X";

      if(Dice_Status.R_DICE_01 == 1)
      {
        this.Advice.GetComponent<Text>().text ="どのマスの駒でも移動可能だよ！";
        OddEven_Cube_Enable();
      }
      else if(Dice_Status.R_DICE_01 % 2 ==1)
      {
        this.Advice.GetComponent<Text>().text ="ターン開始時に白マスの駒が移動可能だよ！";
        Odd_check();
      }
      else
      {
        this.Advice.GetComponent<Text>().text ="ターン開始時に黒マスの駒が移動可能だよ！";
        Even_Check();
      }
    }

    public void Use_Dice_R02()
    {
      Dice_Status.Count = Dice_Status.R_DICE_02;
      Dice_Status.Used_Dice = Define.DICE_R02;
      this.Dice_Count.GetComponent<Text>().text = "残り : " + Dice_Status.Count.ToString();
      this.DICE_R02.GetComponent<Text>().text ="X";

      if(Dice_Status.R_DICE_02 == 1)
      {
        this.Advice.GetComponent<Text>().text ="どのマスの駒でも移動可能だよ！";
        OddEven_Cube_Enable();
      }
      else if(Dice_Status.R_DICE_02 % 2 ==1)
      {
        this.Advice.GetComponent<Text>().text ="ターン開始時に白マスの駒が移動可能だよ！";
        Odd_check();
      }
      else
      {
        this.Advice.GetComponent<Text>().text ="ターン開始時に黒マスの駒が移動可能だよ！";
        Even_Check();
      }
    }


    public void Roll_Dice_B01()
    {
      Dice_Status.B_DICE_01 = Random.Range(1, 6);
      this.DICE_B01.GetComponent<Text>().text = Dice_Status.B_DICE_01.ToString();
      Turn_Change();
      Dice_Status.Count = 0xFF;
    }

    public void Roll_Dice_B02()
    {
      Dice_Status.B_DICE_02 = Random.Range(1, 6);
      this.DICE_B02.GetComponent<Text>().text = Dice_Status.B_DICE_02.ToString();
      Turn_Change();
      Dice_Status.Count = 0xFF;
    }

    public void Roll_Dice_R01()
    {
      Dice_Status.R_DICE_01 = Random.Range(1, 6);
      this.DICE_R01.GetComponent<Text>().text = Dice_Status.R_DICE_01.ToString();
      Turn_Change();
      Dice_Status.Count = 0xFF;
    }

    public void Roll_Dice_R02()
    {
      Dice_Status.R_DICE_02 = Random.Range(1, 6);
      this.DICE_R02.GetComponent<Text>().text = Dice_Status.R_DICE_02.ToString();
      Turn_Change();
      Dice_Status.Count = 0xFF;
    }


    public int Roll_Dice()
    {
        return Random.Range(1, 6);
    }

    public void Roll_Dice_End()
    {
      this.Sound_001.GetComponent<AudioSource>().Play();
      
      DeInit_All_Cube();

      this.Advice.GetComponent<Text>().text ="使用する出目を決めてね！";
      if (Dice_Status.Used_Dice == Define.DICE_B01)
      {
        Roll_Dice_B01();
      }
      else if (Dice_Status.Used_Dice == Define.DICE_B02)
      {
        Roll_Dice_B02();
      }
      else if (Dice_Status.Used_Dice == Define.DICE_R01)
      {
        Roll_Dice_R01();
      }
      else if (Dice_Status.Used_Dice == Define.DICE_R02)
      {
        Roll_Dice_R02();
      }
    }


    public void Dice_Init()
    {
        // R_Dice_0に出目を追加
        Dice_Status.R_DICE_01 = Roll_Dice();
        do
        {
            // R_Dice_1に出目を追加
            Dice_Status.R_DICE_02 = Roll_Dice();
        // R_Dice_0と1が異なる値かつ、奇数と偶数の組み合わせになるまで繰り返し
        } while ((Dice_Status.R_DICE_01 == Dice_Status.R_DICE_02) || ((Dice_Status.R_DICE_01 + Dice_Status.R_DICE_02) % 2 == 0 ));

        // B_Dice_0に出目を追加
        Dice_Status.B_DICE_01 = Roll_Dice();
        do
        {
            // B_Dice_1に出目を追加
            Dice_Status.B_DICE_02 = Roll_Dice();
        // B_Dice_0と1が異なる値かつ、奇数と偶数の組み合わせになるまで繰り返し
        } while ((Dice_Status.B_DICE_01 == Dice_Status.B_DICE_02) || ((Dice_Status.B_DICE_01 + Dice_Status.B_DICE_02) % 2 == 0));


        // Dice の表示を更新
        if ((this.DICE_R01 != null) && (this.DICE_R02 != null) && (this.DICE_B01 != null) && (this.DICE_B02 != null))
        {
            this.DICE_R01.GetComponent<Text>().text = Dice_Status.R_DICE_01.ToString();
            this.DICE_R02.GetComponent<Text>().text = Dice_Status.R_DICE_02.ToString();
            this.DICE_B01.GetComponent<Text>().text = Dice_Status.B_DICE_01.ToString();
            this.DICE_B02.GetComponent<Text>().text = Dice_Status.B_DICE_02.ToString();
        }

        if ((Dice_Status.R_DICE_01 + Dice_Status.R_DICE_02) > (Dice_Status.B_DICE_01 + Dice_Status.B_DICE_02))
        {
            Game_Status.Turn = Define.Blue_Turn;
            this.Game_Turn.GetComponent<Text>().text = "Turn：Blue";

        }
        else if ((Dice_Status.R_DICE_01 + Dice_Status.R_DICE_02) < (Dice_Status.B_DICE_01 + Dice_Status.B_DICE_02))
        {
            Game_Status.Turn = Define.Red_Turn;
            this.Game_Turn.GetComponent<Text>().text = "Turn：Red";

        }
        else // Sum R_Dice == B_Dice
        {
            int R_Max;
            int B_Max;
            if (Dice_Status.R_DICE_01 > Dice_Status.R_DICE_02)
            {
                R_Max = Dice_Status.R_DICE_01;
            }
            else
            {
                R_Max = Dice_Status.R_DICE_02;
            }

            if (Dice_Status.B_DICE_01 > Dice_Status.B_DICE_02)
            {
                B_Max = Dice_Status.B_DICE_01;
            }
            else
            {
                B_Max = Dice_Status.B_DICE_02;
            }

            if (R_Max > B_Max)
            {
                Game_Status.Turn = Define.Blue_Turn;
                this.Game_Turn.GetComponent<Text>().text = "Turn：Blue";
            }
            else if (R_Max < B_Max)
            {
                Game_Status.Turn = Define.Red_Turn;
                this.Game_Turn.GetComponent<Text>().text = "Turn：Red";
            }
            else
            {
                this.Game_Turn.GetComponent<Text>().text = "Re-Dice";
            }
        }

    }// End of Dice_Init


    public void Turn_Change()
    {
        if (Game_Status.Turn == Define.Red_Turn)
        {
          Game_Status.Turn = Define.Blue_Turn;
          this.Game_Turn.GetComponent<Text>().text = "Turn：Blue";
        }
        else
        {
          Game_Status.Turn = Define.Red_Turn;
          this.Game_Turn.GetComponent<Text>().text = "Turn：Red";
        }
    }

    public void DeInit_All_Cube()
    {
　　　　　Game_Status.Kill = false;
      Cube_Status.Status_B_00 = false;
      Cube_Status.Status_B_01 = false;
      Cube_Status.Status_B_02 = false;
      Cube_Status.Status_B_03 = false;
      Cube_Status.Status_B_04 = false;
      Cube_Status.Status_B_05 = false;
      Cube_Status.Status_B_06 = false;
      Cube_Status.Status_B_07 = false;
      Cube_Status.Status_B_08 = false;
      Cube_Status.Status_B_09 = false;
      Cube_Status.Status_B_10 = false;

      if (this.CUBE_B00 != null)
      {
        this.CUBE_B00.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_B01 != null)
      {
        this.CUBE_B01.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_B02 != null)
      {
        this.CUBE_B02.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_B03 != null)
      {
        this.CUBE_B03.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_B04 != null)
      {
        this.CUBE_B04.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_B05 != null)
      {
        this.CUBE_B05.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_B06 != null)
      {
        this.CUBE_B06.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_B07 != null)
      {
        this.CUBE_B07.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_B08 != null)
      {
        this.CUBE_B08.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_B09 != null)
      {
        this.CUBE_B09.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_B10 != null)
      {
        this.CUBE_B10.GetComponent<ParticleSystem>().Stop();
      }

      Cube_Status.Status_R_00 = false;
      Cube_Status.Status_R_01 = false;
      Cube_Status.Status_R_02 = false;
      Cube_Status.Status_R_03 = false;
      Cube_Status.Status_R_04 = false;
      Cube_Status.Status_R_05 = false;
      Cube_Status.Status_R_06 = false;
      Cube_Status.Status_R_07 = false;
      Cube_Status.Status_R_08 = false;
      Cube_Status.Status_R_09 = false;
      Cube_Status.Status_R_10 = false;

      if (this.CUBE_R00 != null)
      {
        this.CUBE_R00.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_R01 != null)
      {
        this.CUBE_R01.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_R02 != null)
      {
        this.CUBE_R02.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_R03 != null)
      {
        this.CUBE_R03.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_R04 != null)
      {
        this.CUBE_R04.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_R05 != null)
      {
        this.CUBE_R05.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_R06 != null)
      {
        this.CUBE_R06.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_R07 != null)
      {
        this.CUBE_R07.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_R08 != null)
      {
        this.CUBE_R08.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_R09 != null)
      {
        this.CUBE_R09.GetComponent<ParticleSystem>().Stop();
      }
      if (this.CUBE_R10 != null)
      {
        this.CUBE_R10.GetComponent<ParticleSystem>().Stop();
      }
 
      int i;
      for (i = 0; i < 22; i++)
      {
        Cube_Status.OddEven_Cube[i] = false;
      }

      for (i = 0; i < 22; i++)
      {
        Cube_Status.Double_Cube[i] = false;
      }
   }


    public bool Check_Status()
    {
        int count = 0;
        bool Return_Value;

        if(Cube_Status.Status_B_00 == true)
        {
            count++;
        }
        if (Cube_Status.Status_B_01 == true)
        {
            count++;
        }
        if (Cube_Status.Status_B_02 == true)
        {
            count++;
        }
        if (Cube_Status.Status_B_03 == true)
        {
            count++;
        }
        if (Cube_Status.Status_B_04 == true)
        {
            count++;
        }
        if (Cube_Status.Status_B_05 == true)
        {
            count++;
        }
        if (Cube_Status.Status_B_06 == true)
        {
            count++;
        }
        if (Cube_Status.Status_B_07 == true)
        {
            count++;
        }
        if (Cube_Status.Status_B_08 == true)
        {
            count++;
        }
        if (Cube_Status.Status_B_09 == true)
        {
            count++;
        }
        if (Cube_Status.Status_B_10 == true)
        {
            count++;
        }

        if (Cube_Status.Status_R_00 == true)
        {
            count++;
        }
        if (Cube_Status.Status_R_01 == true)
        {
            count++;
        }
        if (Cube_Status.Status_R_02 == true)
        {
            count++;
        }
        if (Cube_Status.Status_R_03 == true)
        {
            count++;
        }
        if (Cube_Status.Status_R_04 == true)
        {
            count++;
        }
        if (Cube_Status.Status_R_05 == true)
        {
            count++;
        }
        if (Cube_Status.Status_R_06 == true)
        {
            count++;
        }
        if (Cube_Status.Status_R_07 == true)
        {
            count++;
        }
        if (Cube_Status.Status_R_08 == true)
        {
            count++;
        }
        if (Cube_Status.Status_R_09 == true)
        {
            count++;
        }
        if (Cube_Status.Status_R_10 == true)
        {
            count++;
        }

        if (count == 0)
        {
            Return_Value = true;
        }
        else
        {
            Return_Value = false;
        }

        return Return_Value;
    }

    // ---------------------------------------------------------------------
    // OnClick_B_xx
    //----------------------------------------------------------------------
    public void OnClick_B_00()
    {
        if (this.CUBE_B00.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.B_00] = true;
        }
        else
        {
          // No action
        }

        if ((true == Check_Status()) && (Game_Status.Turn == Define.Blue_Turn) && (Cube_Status.OddEven_Cube[Define.B_00] == true) && (Cube_Status.Double_Cube[Define.B_00] == false))
        {
            Cube_Status.Status_B_00 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_B_00 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_B_01()
    {
        if (this.CUBE_B01.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.B_01] = true;
        }
        else
        {
          // No action
        }

        if ((true == Check_Status()) && (Game_Status.Turn == Define.Blue_Turn) && (Cube_Status.OddEven_Cube[Define.B_01] == true) && (Cube_Status.Double_Cube[Define.B_01] == false))
        {
            Cube_Status.Status_B_01 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_B_01 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_B_02()
    {
        if (this.CUBE_B02.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.B_02] = true;
        }
        else
        {
          // No action
        }

        if ((true == Check_Status()) && (Game_Status.Turn == Define.Blue_Turn) && (Cube_Status.OddEven_Cube[Define.B_02] == true) && (Cube_Status.Double_Cube[Define.B_02] == false))
        {
            Cube_Status.Status_B_02 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_B_02 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_B_03()
    {
        if (this.CUBE_B03.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.B_03] = true;
        }
        else
        {
          // No action
        }

        if ((true == Check_Status()) && (Game_Status.Turn == Define.Blue_Turn) && (Cube_Status.OddEven_Cube[Define.B_03] == true) && (Cube_Status.Double_Cube[Define.B_03] == false))
        {
            Cube_Status.Status_B_03 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_B_03 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_B_04()
    {
        if (this.CUBE_B04.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.B_04] = true;
        }
        else
        {
          // No action
        }

        if ((true == Check_Status()) && (Game_Status.Turn == Define.Blue_Turn) && (Cube_Status.OddEven_Cube[Define.B_04] == true)&&(Cube_Status.Double_Cube[Define.B_04] == false))
        {
            Cube_Status.Status_B_04 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_B_04 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_B_05()
    {
        if (this.CUBE_B05.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.B_05] = true;
        }
        else
        {
          // No action
        }

        if ((true == Check_Status()) && (Game_Status.Turn == Define.Blue_Turn) && (Cube_Status.OddEven_Cube[Define.B_05] == true) && (Cube_Status.Double_Cube[Define.B_05] == false))
        {
            Cube_Status.Status_B_05 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_B_05 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_B_06()
    {
        if (this.CUBE_B06.transform.localScale.y >= 0.5f)
        {
            Cube_Status.OddEven_Cube[Define.B_06] = true;
        }
        else
        {
          // No action
        }

        if ((true == Check_Status()) && (Game_Status.Turn == Define.Blue_Turn) && (Cube_Status.OddEven_Cube[Define.B_06] == true) && (Cube_Status.Double_Cube[Define.B_06] == false))
        {
            Cube_Status.Status_B_06 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_B_06 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_B_07()
    {
        if (this.CUBE_B07.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.B_07] = true;
        }
        else
        {
          // No action
        }

        if ((true == Check_Status()) && (Game_Status.Turn == Define.Blue_Turn) && (Cube_Status.OddEven_Cube[Define.B_07] == true)&&(Cube_Status.Double_Cube[Define.B_07] == false))
        {
            Cube_Status.Status_B_07 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_B_07 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_B_08()
    {
        if (this.CUBE_B08.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.B_08] = true;
        }
        else
        {
          // No action
        }

        if ((true == Check_Status()) && (Game_Status.Turn == Define.Blue_Turn) && (Cube_Status.OddEven_Cube[Define.B_08] == true)&&(Cube_Status.Double_Cube[Define.B_08] == false))
        {
            Cube_Status.Status_B_08 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_B_08 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_B_09()
    {
        if (this.CUBE_B09.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.B_09] = true;
        }
        else
        {
          // No action
        }

        if ((true == Check_Status()) && (Game_Status.Turn == Define.Blue_Turn) && (Cube_Status.OddEven_Cube[Define.B_09] == true)&&(Cube_Status.Double_Cube[Define.B_09] == false))
        {
            Cube_Status.Status_B_09 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_B_09 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_B_10()
    {
        if (this.CUBE_B10.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.B_10] = true;
        }
        else
        {
          // No action
        }
        if ((true == Check_Status()) && (Game_Status.Turn == Define.Blue_Turn) && (Cube_Status.OddEven_Cube[Define.B_10] == true)&&(Cube_Status.Double_Cube[Define.B_10] == false))
        {
            Cube_Status.Status_B_10 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_B_10 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }

    // ---------------------------------------------------------------------
    // OnClick_R_xx
    //----------------------------------------------------------------------
    public void OnClick_R_00()
    {
        if (this.CUBE_R00.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.R_00] = true;
        }
        else
        {
          // No action
        }

        if ((true == Check_Status()) && (Game_Status.Turn == Define.Red_Turn) && (Cube_Status.OddEven_Cube[Define.R_00] == true)&&(Cube_Status.Double_Cube[Define.R_00] == false))
        {
            Cube_Status.Status_R_00 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_R_00 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_R_01()
    {
        if (this.CUBE_R01.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.R_01] = true;
        }
        else
        {
          // No action
        }

        if ((true == Check_Status()) && (Game_Status.Turn == Define.Red_Turn) && (Cube_Status.OddEven_Cube[Define.R_01] == true)&&(Cube_Status.Double_Cube[Define.R_01] == false))
        {
            Cube_Status.Status_R_01 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_R_01 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_R_02()
    {
        if (this.CUBE_R02.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.R_02] = true;
        }
        else
        {
          // No action
        }

        if ((true == Check_Status()) && (Game_Status.Turn == Define.Red_Turn) && (Cube_Status.OddEven_Cube[Define.R_02] == true)&&(Cube_Status.Double_Cube[Define.R_02] == false))
        {
            Cube_Status.Status_R_02 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_R_02 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_R_03()
    {
        if (this.CUBE_R03.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.R_03] = true;
        }
        else
        {
          // No action
        }

        if ((true == Check_Status()) && (Game_Status.Turn == Define.Red_Turn) && (Cube_Status.OddEven_Cube[Define.R_03] == true)&&(Cube_Status.Double_Cube[Define.R_03] == false))
        {
            Cube_Status.Status_R_03 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_R_03 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_R_04()
    {
        if (this.CUBE_R04.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.R_04] = true;
        }
        else
        {
          // No action
        }

        if ((true == Check_Status()) && (Game_Status.Turn == Define.Red_Turn) && (Cube_Status.OddEven_Cube[Define.R_04] == true)&&(Cube_Status.Double_Cube[Define.R_04] == false))
        {
            Cube_Status.Status_R_04 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_R_04 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_R_05()
    {
        if (this.CUBE_R05.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.R_05] = true;
        }
        else
        {
          // No action
        }
        if ((true == Check_Status()) && (Game_Status.Turn == Define.Red_Turn) && (Cube_Status.OddEven_Cube[Define.R_05] == true)&&(Cube_Status.Double_Cube[Define.R_05] == false))
        {
            Cube_Status.Status_R_05 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_R_05 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_R_06()
    {
        if (this.CUBE_R06.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.R_06] = true;
        }
        else
        {
          // No action
        }
        if ((true == Check_Status()) && (Game_Status.Turn == Define.Red_Turn) && (Cube_Status.OddEven_Cube[Define.R_06] == true)&&(Cube_Status.Double_Cube[Define.R_06] == false))
        {
            Cube_Status.Status_R_06 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_R_06 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_R_07()
    {
        if (this.CUBE_R07.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.R_07] = true;
        }
        else
        {
          // No action
        }
        if ((true == Check_Status()) && (Game_Status.Turn == Define.Red_Turn) && (Cube_Status.OddEven_Cube[Define.R_07] == true)&&(Cube_Status.Double_Cube[Define.R_07] == false))
        {
            Cube_Status.Status_R_07 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_R_07 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_R_08()
    {
        if (this.CUBE_R08.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.R_08] = true;
        }
        else
        {
          // No action
        }
        if ((true == Check_Status()) && (Game_Status.Turn == Define.Red_Turn) && (Cube_Status.OddEven_Cube[Define.R_08] == true)&&(Cube_Status.Double_Cube[Define.R_08] == false))
        {
            Cube_Status.Status_R_08 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_R_08 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_R_09()
    {
        if (this.CUBE_R09.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.R_09] = true;
        }
        else
        {
          // No action
        }
        if ((true == Check_Status()) && (Game_Status.Turn == Define.Red_Turn) && (Cube_Status.OddEven_Cube[Define.R_09] == true)&&(Cube_Status.Double_Cube[Define.R_09] == false))
        {
            Cube_Status.Status_R_09 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_R_09 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
    public void OnClick_R_10()
    {
        if (this.CUBE_R10.transform.localScale.y >= 0.5f)
        {
          Cube_Status.OddEven_Cube[Define.R_10] = true;
        }
        else
        {
          // No action
        }
        if ((true == Check_Status()) && (Game_Status.Turn == Define.Red_Turn) && (Cube_Status.OddEven_Cube[Define.R_10] == true)&&(Cube_Status.Double_Cube[Define.R_10] == false))
        {
            Cube_Status.Status_R_10 = true;
            GetComponent<ParticleSystem>().Play();
        }
        else
        {
            Cube_Status.Status_R_10 = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {

      //StartCoroutine("coRoutine");
      if ((7 > Dice_Status.Count) && (Dice_Status.Count > 0))
      {
        this.Dice_Count.GetComponent<Text>().text = "残り : " + Dice_Status.Count.ToString();
      }
      else
      {
        this.Dice_Count.GetComponent<Text>().text = "残り : ";
      }

    } // End of Updated()
} // End of Cube_Controller
