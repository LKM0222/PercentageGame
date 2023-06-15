using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScript : MonoBehaviour
{
    public Map map;

    [SerializeField] List<GameObject> enemySpawn = new List<GameObject>();
    [SerializeField] GameObject enemyPrefab;
    //GameObject enemyHPbar;

    MapSystem theMapSystem;

    // Start is called before the first frame update
    void Start()
    {
        theMapSystem = FindObjectOfType<MapSystem>();

        for(int i = 0;i<enemySpawn.Count;i++){
            var enemy = Instantiate(enemyPrefab,enemySpawn[i].transform.position, Quaternion.identity, enemySpawn[i].transform);
            enemy.GetComponent<EnemyScript>().theEnemy = map.Random_Enemy_Retrun();
            
        }
    }
}
