using UnityEngine;
using System.Collections;

public class camera_controler : MonoBehaviour {

    public Transform sfera;

		// Update is called once per frame
	void FixedUpdate () {

        Rigidbody rigidbody = sfera.GetComponent<Rigidbody>();

        Vector3 vector = new Vector3(4f, -4f, -3f);
        float predkosc = rigidbody.velocity.sqrMagnitude;
        vector = (1F + predkosc/30) * vector;

        Vector3 newPosition = sfera.position - (vector);

        transform.position = Vector3.Lerp(transform.position, newPosition, 0.05f);
        transform.LookAt(sfera);
	}
}
