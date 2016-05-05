using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	public float moveSpeed;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider collision) {
         if(collision.gameObject == GameObject.Find("Terrain"))
            {
            	Debug.Log("tetsz");
            	Destroy(gameObject);
            }
        
    }

    void OnTriggerStay(Collider collision) {
        
            if(collision.gameObject == GameObject.Find("Terrain"))
            {
            	Debug.Log("tetsz");
            	Destroy(gameObject);
            }
        
    }
}
