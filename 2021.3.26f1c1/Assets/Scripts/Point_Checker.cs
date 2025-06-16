using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point_Checker : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Country_Object>())
        {
            Country_Object tmpOBJ = other.GetComponent<Country_Object>();
            if (tmpOBJ.countryBelong == Country.CN)
                Game_Manager.Instance.AddPoint(Country.CN, 1);
            else if(tmpOBJ.countryBelong == Country.US)
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
