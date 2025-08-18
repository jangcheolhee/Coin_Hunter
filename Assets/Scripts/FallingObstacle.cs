using UnityEngine;

public class FallingObstacle : MonoBehaviour
{
    public Rigidbody rg;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 3);
    }

  
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var com = other.GetComponent<PlayerControler>();
            com.Die();

        }
    }
}
