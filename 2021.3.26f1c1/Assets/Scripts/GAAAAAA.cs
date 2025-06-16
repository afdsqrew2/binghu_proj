using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// 如果之前没放命名空间，也可以加上自定义命名空间来避免枚举等的冲突
namespace YourCustomNamespace
{
    public class GAAAAAA : MonoBehaviour
    {
        public static GAAAAAA Instance;

        public int CNPoint;
        public int USPoint;

        public TMPro.TMP_Text txt_CNPoint;
        public TMPro.TMP_Text txt_USPoint;

        private void Awake()
        {
            Instance = this;
            // 游戏开始时清零分数
            CNPoint = 0;
            USPoint = 0;
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
}