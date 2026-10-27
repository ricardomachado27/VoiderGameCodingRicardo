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
            Object.Instantiate(Enemy, transform.position, transform.rotation);
            
        }
    }
}
