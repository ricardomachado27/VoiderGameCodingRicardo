using UnityEngine;

public class GameTime : MonoBehaviour
{

    private float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnCooldown)
        {
            timer = 0;
            SpawnEnemy();

        }
    }
        private void SpawnEnemy()
    {
        Vector3 randomPosition = transform.position;
        randomPosition.y = Random.Range(minPosition, maxPosition);
        Object.Instantiate(enemyObject, randomPosition, transform.rotation);
    }
    }
}
