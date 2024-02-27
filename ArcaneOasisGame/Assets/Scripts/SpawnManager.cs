using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : Singleton<SpawnManager> {
    // (Optional) Prevent non-singleton constructor use.
    protected SpawnManager() { }

    public List<GameObject> objects;
    private List<GameObject> destroyMe = new List<GameObject>();

    public int objectCount = 5;
    
    public float distance = 20f;
    
    private float timePassed = 0f;
    public float timePassedCap = .2f;

    private Vector3 oldCameraPosition;

    List<GameObject> spawnedObjects = new List<GameObject>();

    void Start() {
        oldCameraPosition = Camera.main.transform.position;
        Spawn();
    }

    void Update() {
        if (Vector3.Distance(oldCameraPosition, Camera.main.transform.position) > 5) {
            timePassed += Time.deltaTime;
            if (timePassed > timePassedCap) {
                oldCameraPosition = Camera.main.transform.position;
                Spawn();
                Despawn();
                timePassed = 0f;
            }
        }
    }

    public void Despawn() {
        List<GameObject> replaceme = new List<GameObject>();
        foreach (GameObject lilguy in destroyMe) {
            if (lilguy == null) {

            } else if (Vector3.Distance(lilguy.transform.position, Camera.main.transform.position) > distance+5) {
                DestroyImmediate(lilguy,true);
            } else {
                replaceme.Add(lilguy);
            }
        }
        destroyMe.Clear();
        foreach (GameObject lilguy in replaceme) {
            destroyMe.Add(lilguy);
        }
    }

    public void Spawn() {
        for (int i = 0; i < objectCount; i++) {
            spawnObject();
        }
    }

    public void spawnObject() {
        GameObject oldObject = objects[Random.Range(0, objects.Count)];

        // set location
        float camerax = Camera.main.transform.position.x;
        float cameray = Camera.main.transform.position.y;

        //set angle
        float angle = Random.Range(0.0f,Mathf.PI*2); 

        //set spawn location
        float spawnx = camerax + Mathf.Sin(angle)*distance + Random.Range(-5,5);
        float spawny = cameray + Mathf.Cos(angle)*distance + Random.Range(-5,5);

        if ( spawnx+spawny > 10 || spawnx+spawny < -10 ) {
            GameObject newObject = Instantiate(oldObject) as GameObject;
            newObject.transform.position = new Vector3(spawnx,spawny);
            destroyMe.Add(newObject);
            return;
        }
    }
}
