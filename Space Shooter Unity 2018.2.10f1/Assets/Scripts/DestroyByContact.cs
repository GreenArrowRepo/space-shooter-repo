using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided");
        if (other.tag == "Boundry")
        {
            Debug.Log("collided with boundary");
            return;
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

}
