using System.Collections.Generic;
using UnityEngine;

public class Lists_ObjectSpawning : MonoBehaviour
{
    public List<GameObject> objects = new List<GameObject>();
    public List<GameObject> _objectsCreated = new List<GameObject>();
    private bool _canSpawn;


    private void Start()
    {
        _canSpawn = true;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && _canSpawn)
        {
            int randomIndex = Random.Range(0, objects.Count);
            Vector3 randomPos = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0);
            GameObject go  = Instantiate(objects[randomIndex], randomPos, Quaternion.identity);
            _objectsCreated.Add(go);
        }

        if(_objectsCreated.Count == 10) {
            _canSpawn = false;
            foreach(var obj in _objectsCreated)
            {
                obj.GetComponent<MeshRenderer>().material.color = Color.green;
            }
            _objectsCreated.Clear();
        }
    }
}
