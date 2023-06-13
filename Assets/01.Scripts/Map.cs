using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Map
{
    [SerializeField] int mapCode;
    [SerializeField] List<Enemy> map_enemy_list = new List<Enemy>();

    public Map(int _code){
        mapCode = _code;
    }

    public int Get_Map_Code(){
        return mapCode;
    }
    public void Set_Map_Code(int _code){
        mapCode = _code;
    }

    public void Add_EnemyList(Enemy _enemy){
        map_enemy_list.Add(_enemy);
    }
}
