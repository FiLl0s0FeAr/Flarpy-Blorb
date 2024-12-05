using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe; // attach Pipe prefab
    public float spawnRate = 2; // Pipe spawn rate. parameter which used with counter to define the finite number
    private float timer = 0;    // counter which is used to spawn Pipe
    public float heightOffset = 10; // parameter which is responsible for the random Pipe position

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)  // if counter < than the spawn rate
        {
            timer += Time.deltaTime;    // add time to counter. 1sec
        }
        else
        {
            spawnPipe();    // spawn pipe
            timer = 0;      // reset counter
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;    // add random lowest position
        float highestPoint = transform.position.y + heightOffset;   // add random highest position

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);   // spawn pipe, with position x, y (in range), z). without change the rotation
    }
}
