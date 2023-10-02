using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class S_CharacterMovement : MonoBehaviour
{
    private float speed = 5f;
    public GameObject cube;
    public GameObject cube2;

    private S_CubeRotation s_cube;
    private S_Cube2Rotation s_cube2;

    void Start()
    {
        s_cube = cube.GetComponent<S_CubeRotation>();
        s_cube2 = cube2.GetComponent<S_Cube2Rotation>();
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        this.transform.Rotate(0, Input.GetAxis("Mouse X"), 0);

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(s_cube.enabled == true)
            {
                s_cube.enabled = false;
            }
            else if (s_cube.enabled == false)
            {
                s_cube.enabled = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (s_cube2.enabled == true)
            {
                s_cube2.enabled = false;
            }
            else if (s_cube2.enabled == false)
            {
                s_cube2.enabled = true;
            }
        }
    }

}
