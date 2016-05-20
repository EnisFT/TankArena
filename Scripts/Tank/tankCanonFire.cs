using UnityEngine;
using System.Collections;

public class tankCanonFire : MonoBehaviour {

	private GameObject mbullet;
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
        		mbullet = Instantiate(Resources.Load("SimpleBullet", typeof(GameObject))) as GameObject;
        		mbullet.GetComponent<Bullet>().Fire(gameObject);
        		mbullet.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        		mbullet.transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
	        	mbullet.transform.Translate(Vector3.forward);
		        mbullet.SetActive(true);
		        seconde = 0;
        	}
        }

        /* RaycastHit hitInfo;
        Ray d = new Ray(transform.position, transform.forward);
        Debug.DrawRay(d.origin, d.direction * 100, Color.green);
        if(Physics.Raycast(d, out hitInfo, 1000))
        {
        	Ray d2 = new Ray(hitInfo.point , Vector3.Reflect(d.direction, hitInfo.normal));
        	Debug.DrawRay(d2.origin, d2.direction * 100, Color.green);
        } */
	}
}
