using UnityEngine;

public class barierScript : MonoBehaviour
{
    public logicScript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.gameOver();
    }
}
