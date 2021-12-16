using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.FPS.Game
{
    public class ExplosionForce : MonoBehaviour
    {
        [Tooltip("Adjust explosion force")] public float force;
        [Tooltip("Adjust explosion radius")] public float radius;
        public void Start()
        {
            Collider[] Parts = Physics.OverlapSphere(transform.position, radius);
            foreach (Collider part in Parts)
            {
                Rigidbody rb = part.GetComponent<Rigidbody>();
                if (rb != null)
                {
                   rb.AddExplosionForce(force, transform.position, radius);
                }
            }
        }
    }
}
