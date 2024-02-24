using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : Singleton<SpawnManager>
{
    // (Optional) Prevent non-singleton constructor use.
    protected SpawnManager() { }

    public List<GameObject> objects;

    public int objectCount = 50;

    List<GameObject> spawnedObjects = new List<GameObject>();

    void Start() {
        Spawn();
    }

    void Update() {

    }

    public void Spawn() {
        for (int i = 0; i < objectCount; i++) {
            spawnObject();
        }
    }

    public void spawnObject() {
        GameObject newObject = objects[Random.Range(0, objects.Count)];

        // set location
        float heightSTD = Random.Range(-Camera.main.orthographicSize, Camera.main.orthographicSize);
        float widthSTD = Random.Range(-heightSTD * Camera.main.aspect, heightSTD * Camera.main.aspect);

        Instantiate(newObject);
        newObject.transform.position = new Vector3(widthSTD,heightSTD);

    }
}
