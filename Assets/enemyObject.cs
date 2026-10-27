using UnityEngine;
using UnityEngine.InputSystem;

public class Enemy : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.CompareTag("Enemy"))
            gameObject.SetActive(false);
        {

        }

    }

    public void OnMove(InputValue input)
    {
        rb.linearVelocity = input.Get<Vector2>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
