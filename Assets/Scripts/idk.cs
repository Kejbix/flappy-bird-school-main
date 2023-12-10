using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idk : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start() // Corrected method name to Start
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() // Corrected method name to Update
    {
        rb.velocity = new Vector2(-2f, 0f); // Corrected Vector2 parameters
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup();
        }
    }

    private void Pickup() // Added access modifier
    {
        Debug.Log("Power up picked up!");
        Destroy(gameObject); // Assuming you want to destroy the object when picked up
    }
}

