using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// -------------------------------------------------------------------------------------------
//  Preset Data
// -------------------------------------------------------------------------------------------
public class Preset_Data : MonoBehaviour
{
    public static int LEAK = 255;
    public static int SILENT = 255;
    public static int MAX_ROUND = 255;
    public static int INIT_ROUND = 255;
}
// -------------------------------------------------------------------------------------------

// -------------------------------------------------------------------------------------------
//  Config Data
// -------------------------------------------------------------------------------------------
public class Config_Data : MonoBehaviour
{
    public static int Player_Num = 0;
    public static int Player_Counter = 1;
    public static int Round_Num = 0;
}
// -------------------------------------------------------------------------------------------

// -------------------------------------------------------------------------------------------
//  Player Data
// -------------------------------------------------------------------------------------------
public class Player_Data : MonoBehaviour
{
    public static int[] Imprisonment = new int [11];
    public static int[,] Judge = new int[11, 11];
    public static int[] Init_Imprisonment = new int[11];
}
// -------------------------------------------------------------------------------------------

// -------------------------------------------------------------------------------------------
//  Player Data
// -------------------------------------------------------------------------------------------
public class Result_Data : MonoBehaviour
{
    public static int Win_Player_Num = 0;
    public static int Result_Flag = 0;
}
// -------------------------------------------------------------------------------------------



public class Scene_Manager : MonoBehaviour
{
    InputField inputField;      // プレーヤ数
    InputField inputField_1;    // Maxラウンド数
    InputField inputField_2;    // 減刑
    InputField inputField_3;    // 増刑
    GameObject Player_Number;   // プレーヤ番号
    GameObject Round_Number;    // Round番号
    GameObject Imprisonment_Number; // 懲役
    GameObject Init_Imprisonment_Number; // 初期懲役
    GameObject Max_Round_Number; // Max Round
    GameObject Win_Player;
    GameObject Disp_Player_1;
    GameObject Disp_Player_2;
    GameObject Disp_Player_3;
    GameObject Disp_Player_4;


    // -------------------------------------------------------------------------------------------
    //  シーン移動毎に実施すること。
    // -------------------------------------------------------------------------------------------
    void Start()
    {
        int Disp_Num = Config_Data.Player_Counter;
        int Disp_Round_Num = Config_Data.Round_Num;
        int Disp_Max_Round_Num = Preset_Data.MAX_ROUND;
        int Disp_Imprisonment_Num = Player_Data.Imprisonment[Disp_Num - 1];
        int Disp_Init_Imprisonment_Num = Player_Data.Init_Imprisonment[Disp_Num - 1];


        this.Player_Number = GameObject.Find("Disp_Player_Num");
        this.Round_Number = GameObject.Find("Disp_Round_Num");
        this.Max_Round_Number = GameObject.Find("Disp_Max_Round_Num");
        this.Imprisonment_Number = GameObject.Find("Disp_Imprisonment_Num");
        this.Init_Imprisonment_Number = GameObject.Find("Disp_Init_Imprisonment_Num");
        this.Win_Player = GameObject.Find("Win_Player");

        // -------------------------------------------------------------------------------------------
        //  プレーヤー番号を更新する。
        // -------------------------------------------------------------------------------------------
        if (this.Player_Number != null)
        {
            this.Player_Number.GetComponent<Text>().text = Disp_Num.ToString();
        }
        // -------------------------------------------------------------------------------------------
        //  Round番号を更新する。
        // -------------------------------------------------------------------------------------------
        if (this.Round_Number != null)
        {
            this.Round_Number.GetComponent<Text>().text = Disp_Round_Num.ToString();
        }
        // -------------------------------------------------------------------------------------------
        //  Max Round番号を更新する。
        // -------------------------------------------------------------------------------------------
        if (this.Max_Round_Number != null)
        {
            this.Max_Round_Number.GetComponent<Text>().text = Disp_Max_Round_Num.ToString();
        }
        // -------------------------------------------------------------------------------------------
        //  懲役を更新する。
        // -------------------------------------------------------------------------------------------
        if (this.Imprisonment_Number != null)
        {
            this.Imprisonment_Number.GetComponent<Text>().text = Disp_Imprisonment_Num.ToString();
        }
        // -------------------------------------------------------------------------------------------
        //  初期懲役を更新する。
        // -------------------------------------------------------------------------------------------
        if (this.Init_Imprisonment_Number != null)
        {
            this.Init_Imprisonment_Number.GetComponent<Text>().text = Disp_Init_Imprisonment_Num.ToString();
        }
        // -------------------------------------------------------------------------------------------
        //  Win playerを更新する。
        // -------------------------------------------------------------------------------------------
        if (this.Win_Player != null)
        {
            if (Result_Data.Win_Player_Num == 999)
            {
                this.Win_Player.GetComponent<Text>().text = "全員が密告しました。看守の勝利です。";
            }
            else
            {
                this.Win_Player.GetComponent<Text>().text = "Player " + Result_Data.Win_Player_Num + "の勝利です。";

                this.Disp_Player_1 = GameObject.Find("Disp_Player_1");
                this.Disp_Player_1.GetComponent<Text>().text = "Player 1: 懲役： " + Player_Data.Imprisonment[0] + " 年";

                if (Config_Data.Player_Num < 2)
                {
                    this.Disp_Player_2 = GameObject.Find("Disp_Player_2");
                    this.Disp_Player_2.GetComponent<Text>().text = "";
                }
                else
                {
                    this.Disp_Player_2 = GameObject.Find("Disp_Player_2");
                    this.Disp_Player_2.GetComponent<Text>().text = "Player 2: 懲役： " + Player_Data.Imprisonment[1] + " 年";
                }
                if (Config_Data.Player_Num < 3)
                {
                    this.Disp_Player_3 = GameObject.Find("Disp_Player_3");
                    this.Disp_Player_3.GetComponent<Text>().text = "";
                }
                else
                {
                    this.Disp_Player_3 = GameObject.Find("Disp_Player_3");
                    this.Disp_Player_3.GetComponent<Text>().text = "Player 3: 懲役： " + Player_Data.Imprisonment[2] + " 年";
                }
                if (Config_Data.Player_Num < 4)
                {
                    this.Disp_Player_4 = GameObject.Find("Disp_Player_4");
                    this.Disp_Player_4.GetComponent<Text>().text = "";
                }
                else
                {
                    this.Disp_Player_4 = GameObject.Find("Disp_Player_4");
                    this.Disp_Player_4.GetComponent<Text>().text = "Player 4: 懲役： " + Player_Data.Imprisonment[3] + " 年";
                }
            }
        }

    }

    // -------------------------------------------------------------------------------------------
    //  監視タスクは今のところなし。
    // -------------------------------------------------------------------------------------------
    void Update()
    {
        // No Action
    }

    // -------------------------------------------------------------------------------------------
    //  Config画面にてプレーヤ人数を入れる。
    // -------------------------------------------------------------------------------------------
    public void InputPlayerNum()
    {
        this.inputField = GameObject.Find("InputField").GetComponent<InputField>();
        Config_Data.Player_Num = int.Parse(inputField.text);
    }

    public void InputMaxRound()
    {
        this.inputField_1 = GameObject.Find("InputField_1").GetComponent<InputField>();
        Preset_Data.MAX_ROUND = int.Parse(inputField_1.text);
        Preset_Data.INIT_ROUND = Preset_Data.MAX_ROUND;
    }

    public void InputSilent()
    {
        this.inputField_2 = GameObject.Find("InputField_2").GetComponent<InputField>();
        Preset_Data.SILENT = int.Parse(inputField_2.text);
    }

    public void InputLeak()
    {
        this.inputField_3 = GameObject.Find("InputField_3").GetComponent<InputField>();
        Preset_Data.LEAK = int.Parse(inputField_3.text);
    }
    // -------------------------------------------------------------------------------------------


    // -------------------------------------------------------------------------------------------
    //  Check Player画面より、Player MenuまたはPlayer Confirmに移動する。
    //  Player Confirmに移動する際に乱数で懲役を決める。
    // -------------------------------------------------------------------------------------------
    public void Player_Menu_button()
    {
        if (Config_Data.Round_Num == 0)
        {
            Player_Data.Imprisonment[Config_Data.Player_Counter - 1] = Random.Range(50, 70);
            Player_Data.Init_Imprisonment[Config_Data.Player_Counter - 1] = Player_Data.Imprisonment[Config_Data.Player_Counter - 1];
            SceneManager.LoadScene("Player_Confirm");
        }
        else
        {
            SceneManager.LoadScene("Player_Menu");
        }
    }
    // -------------------------------------------------------------------------------------------

    // -------------------------------------------------------------------------------------------
    // 密告・黙秘ボタン。自分の配列に記録して、Player_Select_button()を呼び出す。
    // -------------------------------------------------------------------------------------------
    public void Player_Select_button_Leak()
    {
        Player_Data.Judge[Config_Data.Round_Num, (Config_Data.Player_Counter - 1)] = 1;
        Player_Select_button();
    }

    public void Player_Select_button_Silent()
    {
        Player_Data.Judge[Config_Data.Round_Num, (Config_Data.Player_Counter - 1)] = 0;
        Player_Select_button();
    }
    // -------------------------------------------------------------------------------------------

    // -------------------------------------------------------------------------------------------
    // 人数分確認したか確認する。確認できていれば、Round０なら次のRound。
    //　Round０以外ならば、 Check_Judge()を呼び出す。
    // -------------------------------------------------------------------------------------------
    public void Player_Select_button()
    {
        Config_Data.Player_Counter++;
        if (Config_Data.Player_Counter <= Config_Data.Player_Num)
        {
            SceneManager.LoadScene("Check_Player");
        }
        else
        {
            if (Config_Data.Round_Num == 0)
            {
                Config_Data.Round_Num++;
                Config_Data.Player_Counter = 1;
                SceneManager.LoadScene("Round");
            }
            else
            {
                Config_Data.Round_Num++;
                Config_Data.Player_Counter = 1;
                Check_Judge();
            }
        }
    }
    // -------------------------------------------------------------------------------------------

    // -------------------------------------------------------------------------------------------
    // 判定処理を行う。
    // -------------------------------------------------------------------------------------------
    public void Check_Judge()
    {
        int Sum = 0;


        if ((Config_Data.Round_Num - 1) < Preset_Data.MAX_ROUND)
        {
            for (int i = 0; i < Config_Data.Player_Num; i++)
            {
                Sum += Player_Data.Judge[(Config_Data.Round_Num - 1), i];
            }

            // 全員密告
            if (Sum == Config_Data.Player_Num)
            {
                Result_Guard_Win();
            }
            // 全員黙秘
            else if (Sum == 0)
            {
                Reduce_Imprisonment();
            }
            else // 誰かが密告
            {
                Add_Imprisonment();
            }
        }
        else // Max Roundまで到達したらゲーム終了
        {
            Result_Prisoner_Win();
        }
    }
    // -------------------------------------------------------------------------------------------

    // -------------------------------------------------------------------------------------------
    // 減刑処理を行う。
    // -------------------------------------------------------------------------------------------
    public void Reduce_Imprisonment()
    {
        for (int i = 0; i < Config_Data.Player_Num; i++)
        {
            Player_Data.Imprisonment[i] -= Preset_Data.SILENT;
            if (Player_Data.Imprisonment[i] <= 0)
            {
                Result_Data.Win_Player_Num = (i + 1);
                Result_Data.Result_Flag = 1;
                break;
            }
        }

        // 釈放者判定
        if (Result_Data.Result_Flag == 1)
        {
            // 釈放者あり、ゲーム終了
            SceneManager.LoadScene("Result");
        }
        else
        {
            SceneManager.LoadScene("Round");
        }

    }

    // -------------------------------------------------------------------------------------------
    // 増刑処理を行う。
    // -------------------------------------------------------------------------------------------
    public void Add_Imprisonment()
    {
        for (int i = 0; i < Config_Data.Player_Num; i++)
        {
            // 黙秘であったプレーヤに余罪を追加
            if (Player_Data.Judge[(Config_Data.Round_Num - 1), i] == 0)
            {
                Player_Data.Imprisonment[i] += Preset_Data.LEAK;
            }
        }

        SceneManager.LoadScene("Round");
    }

    // -------------------------------------------------------------------------------------------
    // Result画面に移動する。 看守　Win
    // -------------------------------------------------------------------------------------------
    public void Result_Guard_Win()
    {
        Result_Data.Win_Player_Num = 999;
        SceneManager.LoadScene("Result");
    }

    // -------------------------------------------------------------------------------------------
    // Result画面に移動する。 Prisoner　Win
    // -------------------------------------------------------------------------------------------
    public void Result_Prisoner_Win()
    {
        //　一番　懲役が少ない人をWinに設定
        int Min_Imprisonment = Player_Data.Imprisonment[0];
        Result_Data.Win_Player_Num = 1;

        for (int i = 0; i < Config_Data.Player_Num; i++)
        {
            if (Min_Imprisonment > Player_Data.Imprisonment[i])
            {
                Min_Imprisonment = Player_Data.Imprisonment[i];
                Result_Data.Win_Player_Num = i + 1;
            }
        }
            SceneManager.LoadScene("Result");
    }

    // -------------------------------------------------------------------------------------------
    // Config画面に移動する。
    // -------------------------------------------------------------------------------------------
    public void Config_button()
    {
        SceneManager.LoadScene("Config");
    }
    // -------------------------------------------------------------------------------------------

    // -------------------------------------------------------------------------------------------
    // Title画面に移動する。
    // -------------------------------------------------------------------------------------------
    public void Title_button()
    {
        SceneManager.LoadScene("Prisoner");
    }
    // -------------------------------------------------------------------------------------------

    // -------------------------------------------------------------------------------------------
    // Round画面に移動する。
    // -------------------------------------------------------------------------------------------
    public void Round_button()
    {
        SceneManager.LoadScene("Round");
    }
    // -------------------------------------------------------------------------------------------

    // -------------------------------------------------------------------------------------------
    // Check Player画面に移動する。
    // -------------------------------------------------------------------------------------------
    public void Check_Player_button()
    {
        SceneManager.LoadScene("Check_Player");
    }
    // -------------------------------------------------------------------------------------------



}
