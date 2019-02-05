using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    [SerializeField]
    private float tumble;

    private new Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        rigidbody.angularVelocity = Random.insideUnitSphere * tumble;
    }


}
