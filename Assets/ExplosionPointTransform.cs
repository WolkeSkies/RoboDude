using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionPointTransform : MonoBehaviour
{
    [Tooltip("Explosion Point")] public GameObject explosionPoint;
    void Start()
    {
        var position = new Vector3(Random.Range(-0.5f, 0.5f), 0, Random.Range(-0.5f, 0.5f));
        position = transform.position - position;
        explosionPoint.transform.position = position;
        Instantiate(explosionPoint, explosionPoint.transform.position, transform.rotation);
    }
}
