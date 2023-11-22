using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager
{
    public T Load<T>(string path)where T : Object  
        // T (Ÿ����)�� ������Ʈ Ÿ���̰ų� ������Ʈ�� ��ӹ��� Ÿ���̿�����
    {
        return Resources.Load<T>(path);
    }

    public GameObject Instantiate(string path, Transform parent = null)
    {          
        GameObject prefab = Load<GameObject>($"Prefabs/{path}"); 
        // prefab�̶�� ������ (���)�� �ִ� ���ӿ�����Ʈ Ÿ���� prefab�� Load�Ѵ�
        if(prefab == null) 
            // ����ִٴ°� ������ �ʾҴٴ� ��, �� ��ΰ� �߸� �Ǿ����� �ǹ���
        {
            Debug.Log($"Failed to load prefab : {path}"); // �α׸� ���
            return null;
        }

        return Object.Instantiate(prefab, parent); 
        // Object�� �Ⱥ��̸� ���� GameObjectŸ���� Instantiate�� �ٽ� ��������� ȣ����
    }

    public void Destroy(GameObject go)
    {
        if (go == null)
            return;
        Object.Destroy(go);
    }
}
