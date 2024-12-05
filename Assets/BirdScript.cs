using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody; // variable which contains the Bird Rigiddbody 2Ds
    public float flapStrenght;      // variable which define the strenght of Bird flap
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive)    // if key Space is pressed
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrenght; // Bird Linear Velocity = go up * Bird flap strenght
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
