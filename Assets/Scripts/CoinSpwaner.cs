using UnityEngine;

public class CoinSpwaner : MonoBehaviour
{
    public GameObject coin;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 1.0f;

    float timer;
    float interval;

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
            GameObject go = Instantiate(coin);
            timer = 0;
            interval = Random.Range(spawnRateMin, spawnRateMax);
            go.transform.position = new Vector3(Random.Range(-4,4), 0.1f, Random.Range(-4, 4));
        }
    }
}
