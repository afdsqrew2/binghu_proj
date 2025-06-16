using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Country
{
    CN, US
}

public class Game_Manager : MonoBehaviour
{
    public static Game_Manager Instance;

    public int CNPoint;
    public int USPoint;

    public TMPro.TMP_Text txt_CNPoint;
    public TMPro.TMP_Text txt_USPoint;

    
    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        txt_CNPoint.text = CNPoint.ToString();
        txt_USPoint.text = USPoint.ToString();
    }

    public void AddPoint(Country country, int point)
    {
        switch (country)
        {
            case Country.CN:
                CNPoint += point;
                break;
            case Country.US:
                USPoint += point;
                break;
        }
    }
}
