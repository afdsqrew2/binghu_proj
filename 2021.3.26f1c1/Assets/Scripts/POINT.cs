using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POINT : MonoBehaviour
{
    // 【新增】游戏启动/场景加载后执行，清零分数
    void Start()
    {
        Game_Manager.Instance.CNPoint = 0;
        Game_Manager.Instance.USPoint = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Country_Object>())
        {
            Country_Object tmpOBJ = other.GetComponent<Country_Object>();
            if (tmpOBJ.countryBelong == Country.CN)
                Game_Manager.Instance.AddPoint(Country.CN, 1);
            else if (tmpOBJ.countryBelong == Country.US)
                Game_Manager.Instance.AddPoint(Country.US, 1);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Country_Object>())
        {
            Country_Object tmpOBJ = other.GetComponent<Country_Object>();
            if (tmpOBJ.countryBelong == Country.CN)
                Game_Manager.Instance.AddPoint(Country.CN, -1);
            else if (tmpOBJ.countryBelong == Country.US)
                Game_Manager.Instance.AddPoint(Country.US, -1);
        }
    }
}