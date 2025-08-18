using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float x, y, z;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x  * Time.deltaTime, y  * Time.deltaTime, z * Time.deltaTime);
    }
}
