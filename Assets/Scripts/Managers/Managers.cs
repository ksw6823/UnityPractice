using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance; // ���ϼ��� ����ȴ�
    static Managers Instance { get { init(); return s_instance; } } // ������ �Ŵ����� ����´�

    InputManager _input = new InputManager(); 
    ResourceManager _resource = new ResourceManager(); // �ν��Ͻ��� ������ _resource ������ �־���
    public static InputManager Input { get { return Instance._input; } } 
    public static ResourceManager Resource { get { return Instance._resource; } }
    // Ŭ������ �����ϴ� ������Ƽ�� �־��༭(Read_Only �ڵ�) ���ϰ����� ������ �ν��Ͻ��� ����

    void Start()
    {
        init();

    }

    void Update()
    {
        _input.OnUpdate();
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
