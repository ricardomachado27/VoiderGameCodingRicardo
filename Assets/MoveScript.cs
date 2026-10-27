using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 10;
    private Vector2 movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(movementSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(movement.x, movement.y, 0) * movementSpeed * Time.deltaTime;
    }
    public void OnMove(InputValue input)
    {
        movement = input.Get<Vector2>();
    }
}
