using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static int VerticaTennis;
    public static int HorizontalTennis;
    public static int VerticalFootball;
    public static int HorizontalFootball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region TennisControls

        //TennisVertical
        if (Input.GetKey(KeyCode.W))
            VerticaTennis = 1;
        else if (Input.GetKey(KeyCode.S))
            VerticaTennis = -1;
        else
            VerticaTennis = 0;

        //TennisHorizontal
        if (Input.GetKey(KeyCode.D))
            HorizontalTennis = 1;
        else if (Input.GetKey(KeyCode.A))
            HorizontalTennis = -1;
        else
            HorizontalTennis = 0;

        #endregion

        #region FootballControls

        //TennisVertical
        if (Input.GetKey(KeyCode.UpArrow))
            VerticalFootball = 1;
        else if (Input.GetKey(KeyCode.DownArrow))
            VerticalFootball = -1;
        else
            VerticalFootball = 0;

        //TennisHorizontal
        if (Input.GetKey(KeyCode.RightArrow))
            HorizontalFootball = 1;
        else if (Input.GetKey(KeyCode.LeftArrow))
            HorizontalFootball = -1;
        else
            HorizontalFootball = 0;

        #endregion

    }
}
