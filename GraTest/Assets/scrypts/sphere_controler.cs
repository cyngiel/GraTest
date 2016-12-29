using UnityEngine;
using System.Collections;

public class sphere_controler : MonoBehaviour {

    public float minY;
    void FixedUpdate () {
        float speed = 10;
        
        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
        rigidbody.isKinematic = false;
       

        if (Input.GetKey(KeyCode.UpArrow)){
            rigidbody.AddTorque(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddTorque(-Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddTorque(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddTorque(-Vector3.forward * speed);
        }
        minY = transform.position.y;
       

        if (minY < -10)
        {
            rigidbody.isKinematic = true;
            transform.position = new Vector3(0f, 1.5f, 0f);
        }
    }
}
