using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : Singleton<SpawnManager>
{
    // (Optional) Prevent non-singleton constructor use.
    protected SpawnManager() { }

    public List<GameObject> objects;

    public int objectCount = 5;
    
    public float distance = 20f;

    List<GameObject> spawnedObjects = new List<GameObject>();

    void Start() {
        Spawn();
    }

    void Update() {
        Spawn();
        Despawn();
    }

    public void Despawn() {
        foreach (GameObject lilguy in objects) {
            if (Vector3.Distance(lilguy.transform.position, Camera.main.transform.position) > distance+10) {
                Destroy(lilguy);
            }
        }
    }

    public void Spawn() {
        for (int i = 0; i < objectCount; i++) {
            spawnObject();
        }
    }

    public void spawnObject() {
        GameObject newObject = objects[Random.Range(0, objects.Count)];

        // set location
        float camerax = Camera.main.transform.position.x;
        float cameray = Camera.main.transform.position.y;

        //set angle
        float angle = Random.Range(0.0f,Mathf.PI*2); 

        //set spawn location
        float spawnx = camerax + Mathf.Sin(angle)*distance;
        float spawny = cameray + Mathf.Cos(angle)*distance;

        Instantiate(newObject);
        newObject.transform.position = new Vector3(spawnx,spawny);

    }
}
