using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBYTime : MonoBehaviour {
    [SerializeField]
    private float lifetime;

    void Start ()
    {
        Destroy(gameObject, lifetime); // the particle will be destroyed after specified lifetime after it is played.
	}
	
	
}
