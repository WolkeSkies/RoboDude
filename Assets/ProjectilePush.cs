using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePush : MonoBehaviour
{
    [Tooltip("Adjust explosion force")] public float force;
    [Tooltip("Adjust explosion radius")] public float radius;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Collider[] objects = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider part in objects)
        {
            Rigidbody rb = part.GetComponent<Rigidbody>();
            if (collision.gameObject.name == "Cube")
            {
                rb.AddExplosionForce(force, transform.position, radius);
            }
        }
    }
}
