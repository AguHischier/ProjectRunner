using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed = 3;
 
    

    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);
    }
}
