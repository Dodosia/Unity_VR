using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class S_CharacterMovement : MonoBehaviour
{
    private float speed = 5f;
    bool active1 = true;
    bool active2 = true;
    public GameObject cube;
    public GameObject cube2;

    void Start()
    {
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
            if(active1 == true)
            {
                cube.SetActive(false);
                active1 = false;
            }
            else if (active1 == false)
            {
                cube.SetActive(true);
                active1 = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (active2 == true)
            {
                cube2.SetActive(false);
                active2 = false;
            }
            else if (active2 == false)
            {
                cube2.SetActive(true);
                active2 = true;
            }
        }
    }

}
