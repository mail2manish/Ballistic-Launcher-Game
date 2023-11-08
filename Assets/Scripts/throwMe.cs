using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwMe : MonoBehaviour
{
    public GameObject ballPre;
    public Transform throwPoint;
    public float throwforce;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            throww();
        }
    }

    public void throww()
    {
        GameObject ball = Instantiate(ballPre, throwPoint.position, Quaternion.identity);
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        Vector3 throwdirection = throwPoint.forward;
        rb.AddForce(throwdirection * throwforce, ForceMode.Impulse);
    }
}
