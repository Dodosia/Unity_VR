using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Cube2Rotation : MonoBehaviour
{
    public float speed = 10f;
    public bool is_rotating = true;

    void Update()
    {
         this.transform.Rotate(Vector3.left * speed * Time.deltaTime);
    }

}
