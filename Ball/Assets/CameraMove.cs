using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform playerTransForm;
    Vector3 Offset;

    void Start()
    {
        playerTransForm = GameObject.FindGameObjectWithTag("Player").transform;
        Offset = transform.position - playerTransForm.position;
    }

    void LateUpdate()
    {
        transform.position = playerTransForm.position + Offset;
    }
}
