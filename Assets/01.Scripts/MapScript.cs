using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScript : MonoBehaviour
{
    public Map map;

    [SerializeField] List<GameObject> enemySpawn = new List<GameObject>();

    MapSystem theMapSystem;

    // Start is called before the first frame update
    void Start()
    {
        theMapSystem = FindObjectOfType<MapSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
