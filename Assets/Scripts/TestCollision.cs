using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    // 1) �� Ȥ�� ������� RiidBody �־�� �Ѵ�. (IsKinematic : Off)
    // 2) ������ Collider�� �־�� �Ѵ�. (IsTrigger : Off)
    // 3) ������� Collider�� �־�� �Ѵ� (IsTrigger : Off)
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision @ {collision.gameObject.name} !");   
    }

    // 1) �� �� Collider�� �־�� �Ѵ�
    // 2) �� �� �ϳ��� IsTrigger : On
    // 3) �� �� �ϳ��� RigidBody�� �־�� �Ѵ�.
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Trigger @ {other.gameObject.name} !");
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
