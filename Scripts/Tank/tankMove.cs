using UnityEngine;
using System.Collections;

public class tankMove : MonoBehaviour {

	public float moveSpeed;
	public float turnSpeed;
	public int life;

	// Use this for initialization
	void Start ()
	{
		life = 2;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
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
		transform.eulerAngles =  new Vector3(0, transform.eulerAngles.y, 0 );
	}

	public void TakeDamage(int damage)
	{
		life = life - 1;

		if(life <= 0)
		{
			Destroy(gameObject);
		}
	}
}