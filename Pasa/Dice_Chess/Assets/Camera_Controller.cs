using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    GameObject Main_Camera;
    static int Index = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.Main_Camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change_Camera()
    {
        if (Index == 0)
        {
            this.Main_Camera.transform.localPosition = new Vector3(4, 5, 0);
            this.Main_Camera.transform.eulerAngles = new Vector3(120, 90, 180);
            Index++;
        }
        else if (Index == 1)
        {
            this.Main_Camera.transform.localPosition = new Vector3(0, 5, 3);
            this.Main_Camera.transform.eulerAngles = new Vector3(60, 180, 0);
            Index++;
        }
        else if (Index == 2)
        {
            this.Main_Camera.transform.localPosition = new Vector3(-4, 5, 0);
            this.Main_Camera.transform.eulerAngles = new Vector3(120, -90, 180);
            Index++;
        }
        else if (Index == 3)
        {
            this.Main_Camera.transform.localPosition = new Vector3(0, 5, -3);
            this.Main_Camera.transform.eulerAngles = new Vector3(60, 0, 0);
            Index = 0;
        }

    }
}
