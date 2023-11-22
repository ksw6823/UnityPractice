using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance; // 유일성이 보장된다
    static Managers Instance { get { init(); return s_instance; } } // 유일한 매니저를 갖고온다

    InputManager _input = new InputManager(); 
    ResourceManager _resource = new ResourceManager(); // 인스턴스를 생성해 _resource 변수에 넣어줌
    public static InputManager Input { get { return Instance._input; } } 
    public static ResourceManager Resource { get { return Instance._resource; } }
    // 클래스를 참조하는 프로퍼티를 넣어줘서(Read_Only 코드) 리턴값으로 생성한 인스턴스를 받음

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
            // 초기화
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
