using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour 
{
    public float speed;
    private Vector3 v3;

	void Start () 
	{
		
	}
	

	void Update () 
	{
        v3.x = Input.GetAxis("Horizontal");
        v3.z = Input.GetAxis("Vertical");

        transform.Translate(v3 * speed * Time.deltaTime);
	}
}
