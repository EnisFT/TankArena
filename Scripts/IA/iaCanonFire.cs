using UnityEngine;
using System.Collections;

public class iaCanonFire : MonoBehaviour {


	private GameObject mbullet;
	private GameObject enemy;

	public RaycastHit hitInfo1;
	public RaycastHit hitInfo2;
	public RaycastHit hitInfo3;
	public Ray ray1;
	public Ray ray2;
	public Ray ray3;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Actualiser()
	{
		ray1 = new Ray(transform.position, transform.forward);
        
		
        if(Physics.Raycast(ray1, out hitInfo1, 1000))
        {
        	Debug.DrawRay(ray1.origin, ray1.direction * hitInfo1.distance, Color.green);

        	ray2 = new Ray(hitInfo1.point , Vector3.Reflect(ray1.direction, hitInfo1.normal));
        	

        	Physics.Raycast(ray2, out hitInfo2, 1000);

        	Debug.DrawRay(ray2.origin, ray2.direction * hitInfo2.distance, Color.green);
        } 
	}

	public void Fire()
	{
		mbullet = Instantiate(Resources.Load("SimpleBullet", typeof(GameObject))) as GameObject;
		mbullet.GetComponent<Bullet>().bulletSpeed = 25;
		mbullet.GetComponent<Bullet>().Fire(gameObject);
		mbullet.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
		mbullet.transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
		mbullet.transform.Translate(Vector3.forward);
		mbullet.SetActive(true);
	}
}
