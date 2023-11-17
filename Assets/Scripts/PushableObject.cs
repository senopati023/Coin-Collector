using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushableObject : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 pushForce = new Vector3(5f, 0f, 0f); // Gaya dorong yang diberikan pada benda

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Cek apakah pemain menyentuh benda
        if (collision.collider.CompareTag("Player"))
        {
            // Dapatkan arah dorongan berdasarkan input pemain
            Vector3 pushDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

            // Berikan gaya dorong pada benda
            
        }
    }
}