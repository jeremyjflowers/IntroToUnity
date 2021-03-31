using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnBehaviour : MonoBehaviour
{
    //The lowest y-position allowed
    public float YMin;
    //The highest y-position allowed
    public float YMax;
    //Time inbetween spawns
    public float TimeInterval;
    public bool GameOver = false;
    //Pipe Reference
    public GameObject PipeRef;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPipes());
    }

    public IEnumerator SpawnPipes()
    {
        while (!GameOver)
        {
            //Find a random spawn position for the pipe
            float randY = Random.Range(YMin, YMax);
            Vector3 spawnPosition = new Vector3(transform.position.x, randY, transform.position.z);

            //Spawn in an instance of the pipe prefab at the given position with a default rotation
            GameObject pipe = Instantiate(PipeRef.gameObject, spawnPosition, new Quaternion());
            //Get the movement component attached to the spawned object
            MovementBehaviour moveScript = pipe.GetComponent<MovementBehaviour>();
            //Set the starting cosine to be a random value
            moveScript.StartCos = Random.Range(-1, 1);

            //Wait for the given time interval before resuming the function
            yield return new WaitForSeconds(TimeInterval);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
