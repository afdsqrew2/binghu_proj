using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// ���֮ǰû�������ռ䣬Ҳ���Լ����Զ��������ռ�������ö�ٵȵĳ�ͻ
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
            // ��Ϸ��ʼʱ�������
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