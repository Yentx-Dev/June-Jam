using UnityEngine;

public class SpeedPuddle : MonoBehaviour
{
    [SerializeField] public int speedBoost;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player collision");
            PlayerController playerController = other.GetComponentInParent<PlayerController>();
            float currSpeed = playerController.getSpeed();
            StartCoroutine(playerController.speedBoost(currSpeed + speedBoost));
        }
    }

}
