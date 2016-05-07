using UnityEngine;
using System.Collections;

public class tankFireCanon : MonoBehaviour {

	public GameObject reference;
	public float distanceFromCanon;
	private GameObject bullet;
	private float seconde;
	public float cooldown;

	// Use this for initialization
	void Start () {
		seconde = 4;
	}
	
	// Update is called once per frame
	void Update () {
		seconde += Time.deltaTime;
		if (Input.GetMouseButtonDown(0))
        {
        	if(seconde >= cooldown)
        	{
        		bullet = (GameObject)Instantiate(reference, transform.position, transform.rotation);
	        	bullet.transform.Translate(Vector3.forward * distanceFromCanon);
		        bullet.SetActive(true);
		        seconde = 0;
        	}
        }
	}
}