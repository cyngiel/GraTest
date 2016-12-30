using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
    //Vector3 velocity, acceleration;
    //public float startAcc;
	// Use this for initialization
	void Start () {
        //velocity = new Vector3();
        //acceleration = new Vector3(startAcc, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
        //vectorAdd(velocity, acceleration, Time.deltaTime);
        //vectorAdd(transform.position, velocity, Time.deltaTime);
        //transform.position.Set(0, 0, transform.position.z + 1);

        transform.position.Set(0, 4, 150); // co jest z tym nie tak?
    }

    void vectorAdd(Vector3 v1, Vector3 v2, float scl)
    {
        v1.Set(v1.x + v2.x * scl, v1.y + v2.y * scl, v1.z + v2.z * scl);
    }

}
