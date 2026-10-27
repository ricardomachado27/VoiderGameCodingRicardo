using UnityEngine;

public class GameTime : MonoBehaviour
{
    public GameObject enemyObject;
    public float spawnCool;

    public float minPosition;
    public float maxPosition;
    public float minEnemySpeed;

    public float maxEnemySpeed;
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
        GameObject.Instantiate(enemyObject, randomPosition, transform.rotation);

        int targetEnemyIndex = Random.Range(0, enemyObjects.Length);


        float randomSpeed = Random.Range(minEnemySpeed, maxEnemySpeed);
        EnemyMovement enemyMovement = enemy.GetComponent<EnemyMovement>();
        enemyMovement.moveSpeed = randomSpeed;
    }
    }
}
