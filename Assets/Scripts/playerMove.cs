using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float speed = 5.0f;
    float dir;

    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 direction = new Vector3();
            direction = transform.forward * (speed * Time.deltaTime);
            transform.Translate(direction, Space.World);
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 direction = new Vector3();
            direction = transform.forward * (speed * Time.deltaTime);
            transform.Translate(-direction, Space.World);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            dir = 10 * Time.deltaTime;
            transform.Rotate(0f, dir * 10, 0f,Space.Self);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            dir = -10 * Time.deltaTime;
            transform.Rotate(0f, dir * 10, 0f,Space.Self);
        }

    }
}
