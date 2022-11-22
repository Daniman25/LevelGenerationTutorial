using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{

    public GameObject[] objects;
    // Start is called before the first frame update
    void Start()
    {
        //on start up we want to instantiate a random variable from the array of GameObjects at the
        //spawnpoint's position
        int rand = Random.Range(0, objects.Length);
        GameObject instance = (GameObject) Instantiate(objects[rand], transform.position, Quaternion.identity);
        instance.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
