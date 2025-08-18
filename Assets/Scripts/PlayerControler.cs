using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10f;
   
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 velocity = new Vector3(h, 0f, v);
        if (velocity.magnitude > 1)
        {
            velocity.Normalize();
        }
        velocity *= speed;
        rb.linearVelocity = velocity;

    }
    public void Die()
    {
        gameObject.SetActive(false);
        GameObject fin = GameObject.FindWithTag("GameController");
        var com = fin.GetComponent<GameManager>();
        com.EndGame();
    }
}
