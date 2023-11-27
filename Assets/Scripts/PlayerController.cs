using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;


    void Start()
    {
        Managers.Input.KeyAction -= OnKeyboard; // �̹� ȣ���� ���¶�� �ϴ� �����ϰ� �ٽ� �߰��ϱ� ����
        Managers.Input.KeyAction += OnKeyboard;
    }

    void Update()
    {

        // ���� ȸ����
        //transform.eulerAngles = new Vector3(0.0f, _yAngle, 0.0f);

        // +- delta
        //transform.Rotate(new Vector3(0.0f, Time.deltaTime * 100.0f, 0.0f));

        //transform.rotation = Quaternion.Euler(new Vector3(0.0f, _yAngle, 0.0f));
    }

    void OnKeyboard()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.1f);
            transform.position += Vector3.forward * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.1f);
            transform.position += Vector3.back * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.1f);
            transform.position += Vector3.left * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.1f);
            transform.position += Vector3.right * Time.deltaTime * _speed;
            //hi
        }
    }
}
