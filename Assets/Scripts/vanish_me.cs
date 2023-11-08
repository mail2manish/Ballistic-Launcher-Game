using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vanish_me : MonoBehaviour
{
    
    public float rotateSpeed;
    
    void OnCollisionEnter(Collision other)
    {
        
        if(other.gameObject.CompareTag("ball"))
        {
           
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }
}
