using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance; // ���ϼ��� ����ȴ�
    public static Managers Instance { get { init(); return s_instance; } } // ������ �Ŵ����� ����´�


    void Start()
    {
        init();

    }

    void Update()
    {
        
    }

    static void init()
    {
        if (s_instance == null)
        {
            // �ʱ�ȭ
            GameObject go = GameObject.Find("@Managers");
            if(go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();
        }

    }
}
