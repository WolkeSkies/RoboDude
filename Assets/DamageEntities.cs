using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.FPS.Game 
{
    public class DamageEntities : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {

            // I'm not actually doing anything with these yet

        }

        // Update is called once per frame
        void Update()
        {
            
        }

        void OnCollisionEnter(Collision collision)
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            if (collision.gameObject.name == "Player")
            {
                GameObject player = collision.gameObject;
                player.GetComponent<Health>().CurrentHealth -= rb.velocity.magnitude;
            }

        }
    }
}
