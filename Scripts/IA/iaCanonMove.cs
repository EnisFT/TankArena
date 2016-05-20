using UnityEngine;
using System.Collections;

public class iaCanonMove : MonoBehaviour {

	public float rotateSpeed;
	public int level;

    private Vector3 mousePos;
    private float targetAngle;
    private float seconde;
	public float cooldown;

    private GameObject enemy;
    private GameObject canon;

	// Use this for initialization
	void Start () 
	{
		seconde = 4;
		canon = transform.GetChild(1).gameObject;
	}
	
	// Update is called once per frame
	void Update () 
	{
		

		if(enemy != null)
		{

	        seconde += Time.deltaTime;
		
	        if(seconde >= cooldown && enemy != null)
	       	{
	       		RaycastHit hitInfo;

	       		if(level == 1)
	       		{
	       			Vector3 D = enemy.transform.position - transform.position;
		            Quaternion rot = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(D), rotateSpeed * Time.deltaTime);
		            transform.rotation = rot;
		            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

		            
	       			if(canon.GetComponent<iaCanonFire>().hitInfo1.collider.gameObject.tag == "Tank")
		       		{
		       				FireFromCanon();
		       		}

	       		}
	       		else if(level == 2)
	       		{
	       			
	       			Vector3 D = enemy.transform.position - transform.position;
		            Quaternion rot = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(D), rotateSpeed * Time.deltaTime);
		            transform.rotation = rot;
		            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

		            ActualiserFromCanon();
	       			if(canon.GetComponent<iaCanonFire>().hitInfo1.collider.gameObject.tag == "Tank")
		       		{
		       				FireFromCanon();
		       		}
		       		else
		       		{
		       			transform.eulerAngles = new Vector3(0, transform.eulerAngles.y - 30, 0);
		       			for(int i = 0; i <= 60; i = i + 3)
		       			{
		       				transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 3, 0);
		       				ActualiserFromCanon();
		       				if(canon.GetComponent<iaCanonFire>().hitInfo2.collider.gameObject.tag == "Tank")
				       		{
				       				FireFromCanon();
				       				i = 61;
				       		}

		       			}

		       		}

	       		}
	        }
		}
		else
		{
			enemy = GameObject.FindWithTag("Tank");
		}
	}

	void FireFromCanon()
	{
		canon.GetComponent<iaCanonFire>().Fire();
		seconde = 0;
	}

	void ActualiserFromCanon()
	{
		canon.GetComponent<iaCanonFire>().Actualiser();
	}
}