using UnityEngine;

public class Bullet : MonoBehaviour {

    public float bulletSpeed;
    public int bulletDamage;

    private bool isAlive;
    private Ray ray;

    private RaycastHit hit;
    private LayerMask hitable;

    public void Start() {
        hitable = 1 << 8 | 1 << 9 | 1 << 10 | 1 << 11 | 1 << 12;
    }

    public void Fire(GameObject source) {
        transform.eulerAngles = source.gameObject.transform.eulerAngles;
        transform.position = source.gameObject.transform.position;
        foreach (var component in GetComponents(typeof(BulletEffect))) {
            ((BulletEffect)component).OnCreation();
        }
        isAlive = true;
    }

    void Update() {
        if (isAlive) {
            foreach (var component in GetComponents(typeof(BulletEffect))) {
                ((BulletEffect)component).OnRefreshTimer();
            }
            Vector3 startPos = transform.position + transform.forward * transform.GetComponent<BoxCollider>().size.z;
            if (Physics.Raycast(startPos, transform.forward, out hit, 0.5f, hitable)) {
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
