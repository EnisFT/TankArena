using UnityEngine;
using System.Collections;
using System;

public class SplitEffect : BulletEffect {
    public int splitCounter;
    public GameObject splitPrefab;
    public float splitAngle;

    public override void Effect(EffectSource source) {
        transform.Rotate(Vector3.up, splitAngle);
        float angleStart = splitAngle / 2f;
        float angleIncrement = splitAngle / splitCounter;
        for (int s = 0; s < splitCounter; s++) {
            GameObject bulletClone = Instantiate(gameObject);
            bulletClone.name = "Bullet";

            if (source == EffectSource.Creation) {
                bulletClone.GetComponent<SplitEffect>().applyOnCreation = false;
            }

            bulletClone.transform.position = transform.position;
            bulletClone.transform.rotation = transform.rotation;
            bulletClone.GetComponent<Bullet>().Fire(gameObject);
            bulletClone.transform.Rotate(Vector3.up, angleStart + angleIncrement * s);
        }
        Destroy(gameObject);
    }
}
