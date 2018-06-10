using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour 
{
	public float speed;
    public bool fall;

	void Start ()
	{
        speed = 0.1f;
        fall = false;
        GetComponent<Rigidbody>().AddTorque(Vector3.up * 1);

	}

    private void FixedUpdate()
    {
        if (!fall)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * speed);
            if (transform.position.y > 1.4)
                fall = true;
        }
        else
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * -speed);
            if (transform.position.y < 1.4)
                fall = false;
        }
        
    }

}