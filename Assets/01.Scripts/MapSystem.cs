using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MapSystem : MonoBehaviour
{
    //맵 리스트를 작성해서 나중에 불러오기!
    [Header("Stage1")]
    [SerializeField] List<GameObject> stage1Maplist = new List<GameObject>();
    [SerializeField] List<GameObject> maplist = new List<GameObject>();
    [SerializeField] GameObject spawnedMap;
    int mapIdx;
    DataBase theDB;

    private void Awake()
    {
        theDB = FindObjectOfType<DataBase>();
    }
    

    // Start is called before the first frame update
    void Start()
    {
        Vector3 mapPos = this.transform.position;
        for(int i=0;i<10;i++){
            MapSpawn(1,mapPos);
            float mapXSize = spawnedMap.GetComponent<BoxCollider2D>().bounds.size.x;
            mapPos += new Vector3(mapXSize, 0f, 0f);
        }
    }

    public void MapSpawn(int _mapType,Vector3 _mapPos){
        maplist = ReturnMapList(_mapType);
        mapIdx = Random.Range(0,maplist.Count);
        var map = Instantiate(maplist[mapIdx], _mapPos, Quaternion.identity, this.transform);
        spawnedMap = map;
        map.GetComponent<MapScript>().map = maplist[mapIdx].GetComponent<MapScript>().map;
    }

    public List<GameObject> ReturnMapList(int _mapType){
        switch(_mapType){
            case 1:
                return stage1Maplist;

            default:
                return null;
        }
    }
}
