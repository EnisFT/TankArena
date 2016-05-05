using UnityEngine;
using System.Collections;

public class Mine : MonoBehaviour {

    public GameObject MinePrefab;
    private float seconde = 0;
    
    // Use this for initialization
    void Start () {
      
    }

    // Update is called once per frame
    void Update() {
    seconde += Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space) && seconde >= 4)
            { 
                GameObject mineGo = Instantiate(MinePrefab);
                mineGo.transform.position = transform.position;
                seconde = 0;
            }
            
          
    }

    void OnTriggerEnter(Collider colid) {
        if (seconde >= 4)
        {
            Destroy(colid.gameObject);
            Destroy(gameObject);
        }
    }
}