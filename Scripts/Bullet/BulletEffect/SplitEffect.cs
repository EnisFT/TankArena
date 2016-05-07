using UnityEngine;
using System.Collections;
using System;

public class SplitEffect : BulletEffect {
    public int splitCounter;
    public GameObject splitPrefab;
    public float splitAngle;

    public override void Effect(EffectSource source) {
        if ((hitting == true && hit.collider.gameObject.layer != LayerMask.NameToLayer("Bullet")) || hitting == false) {
            float angleStart;
            float angleBetweenBullet;

            if (splitCounter == 1 || splitCounter == 0) {
                angleBetweenBullet = 0;
                angleStart = 0;
            }
            else {
                angleBetweenBullet = splitAngle / (splitCounter - 1);
                angleStart = splitAngle / 2f;
            }

            for (int s = 0; s < splitCounter; s++) {
                GameObject bulletClone = Instantiate(gameObject);
                bulletClone.name = "Bullet";

                if (source == EffectSource.Creation) {
                    bulletClone.GetComponent<SplitEffect>().applyOnCreation = false;
                }
                 
                bulletClone.GetComponent<Bullet>().Fire(gameObject);
                bulletClone.transform.Rotate(Vector3.up, -angleStart + angleBetweenBullet * s);
            }
            Destroy(gameObject);
        }        
    }
}
