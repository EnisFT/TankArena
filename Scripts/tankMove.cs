using UnityEngine;
using System.Collections;

public class tankMove : MonoBehaviour {

	public float moveSpeed;
	public float turnSpeed;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKey(KeyCode.Z))
		{
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		}
		else if(Input.GetKey(KeyCode.S))
		{
			transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.D))
		{
			transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.Q))
		{
			transform.Rotate(-Vector3.up, turnSpeed * Time.deltaTime);
		}

		transform.eulerAngles =  new Vector3(0, transform.eulerAngles.y, 0);
	}
}
