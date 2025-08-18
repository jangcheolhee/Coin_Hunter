using UnityEngine;

public class ObjstacleSpawner : MonoBehaviour
{
    public GameObject obs;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 1.0f;

    private float timer;
    private float interval;

    private void OnEnable()
    {
        timer = 0;
        interval = Random.Range(spawnRateMin, spawnRateMax);
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > interval)
        {
            GameObject go = Instantiate(obs);
            go.transform.position = new Vector3(Random.Range(-4,4),10f, Random.Range(-4, 4));
            go.transform.rotation = Quaternion.Euler(45, 45, 45);
            timer = 0;
            interval = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
