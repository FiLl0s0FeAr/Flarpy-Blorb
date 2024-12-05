using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5; // Pipe move speed
    public float deadZone = -30;    // x position from the center of the board, after which Pipe will be destroyed

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;  // change Pipe position to the left with defined move speed after some time. need to not so as to get attached to the time frame 

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
