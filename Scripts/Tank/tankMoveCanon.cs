using UnityEngine;
using System.Collections;

public class tankMoveCanon : MonoBehaviour {

	public float rotateSpeed;

    private Vector3 mousePos;
    private float targetAngle;
	
	void Update () {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo, 1000)) {
            Vector3 D = hitInfo.point - transform.position;
            Quaternion rot = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(D), rotateSpeed * Time.deltaTime);
            transform.rotation = rot;
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        }
    }
}
