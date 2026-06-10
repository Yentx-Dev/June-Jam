using UnityEngine;

public class TrashStick : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.isKinematic = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = GetComponent<Rigidbody>(); //Gets rigidbody component on current object

        if (other.CompareTag("surface")) //Checks if collided tag is "surface"
        {
            rb.isKinematic = true; //Sets rigidbody to kinematic so it will be stationary
            Destroy(gameObject, 10);
            Debug.Log("Object destoyed after 5 seconds");
        }
        
    }
}
