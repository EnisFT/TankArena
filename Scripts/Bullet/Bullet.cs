using UnityEngine;
using System;
using System.Collections.Generic;

public class Bullet : MonoBehaviour {

    public float bulletSpeed;
    public int bulletDamage;

    private bool isAlive;
    private Ray ray;

    private RaycastHit hit;
    private LayerMask obstacle;

    public void Start() {
        obstacle = 1 << LayerMask.NameToLayer("Obstacle");
    }

    public void Fire(GameObject source) {
        transform.eulerAngles = source.gameObject.transform.eulerAngles;
        transform.position = source.gameObject.transform.position;
        foreach (var component in GetComponents(typeof(BulletEffect))) {
            ((BulletEffect)component).OnCreation() ;
        }
        Debug.Log(GetComponent<BounceEffect>().numberOfBounce);
        isAlive = true;
    }

    void Update() {
        if (isAlive) {
            foreach (var component in GetComponents(typeof(BulletEffect))) {
                ((BulletEffect)component).OnRefreshTimer();
            }
            if (Physics.Raycast(transform.position, transform.forward, out hit, 0.5f)) {
                foreach (var component in GetComponents(typeof(BulletEffect))) {
                    ((BulletEffect)component).OnObstacleCollision(hit);
                }
                if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Tank")) {
                    OnDestroy();
                }
            }
            transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime, Space.Self);
        }
    }

    public void OnDestroy() {
        foreach (var component in GetComponents(typeof(BulletEffect))) {
            ((BulletEffect)component).OnDestruction();
        }
        Destroy(gameObject);
    }

}
