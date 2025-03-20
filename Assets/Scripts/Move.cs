using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject obj;
    public float MoveSpeed = 4f;


    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            obj.transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            obj.transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime);

    }
}
