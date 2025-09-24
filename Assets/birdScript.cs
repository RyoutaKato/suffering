using UnityEngine;
using UnityEngine.InputSystem;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    public float velocity;
    public logicScript logic;
    public bool flapIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame || Mouse.current.leftButton.wasPressedThisFrame)
        {
            if (flapIsAlive)
                myRigidbody.linearVelocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        flapIsAlive = false;
    }
}
