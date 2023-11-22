using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager
{
    public T Load<T>(string path)where T : Object  
        // T (타입이)가 오브젝트 타입이거나 오브젝트를 상속받은 타입이여야함
    {
        return Resources.Load<T>(path);
    }

    public GameObject Instantiate(string path, Transform parent = null)
    {          
        GameObject prefab = Load<GameObject>($"Prefabs/{path}"); 
        // prefab이라는 변수에 (경로)에 있는 게임오브젝트 타입의 prefab을 Load한다
        if(prefab == null) 
            // 비어있다는건 들어오지 않았다는 것, 즉 경로가 잘못 되었음을 의미함
        {
            Debug.Log($"Failed to load prefab : {path}"); // 로그를 띄움
            return null;
        }

        return Object.Instantiate(prefab, parent); 
        // Object를 안붙이면 위에 GameObject타입의 Instantiate를 다시 재귀적으로 호출함
    }

    public void Destroy(GameObject go)
    {
        if (go == null)
            return;
        Object.Destroy(go);
    }
}
