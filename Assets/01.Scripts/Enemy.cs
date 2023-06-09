using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DropItem{
    Item item;
    float percent;
}
[System.Serializable]
public class Enemy
{
    string enemy_name;
    int enemy_code, enemy_hp, enemy_coin, enemy_exp;
    List<DropItem> dropItems = new List<DropItem>();

    public Enemy(string _name,int _code, int _hp, int _coin, int _exp){
        enemy_name = _name;
        enemy_code = _code;
        enemy_hp = _hp;
        enemy_coin = _coin;
        enemy_exp = _exp;
    }

    //getter
    public int Get_enemy_hp(){
        return enemy_hp;
    }
    public int Get_enemy_code(){
        return enemy_code;
    }
    public string Get_enemy_name(){
        return enemy_name;
    }
    public int Get_enemy_coin(){
        return enemy_coin;
    }
    public int Get_enemy_exp(){
        return enemy_exp;
    }

    //setter
    public void Set_enemy_hp(int _hp){
        enemy_hp = _hp;
    }
    public void Set_enemy_code(int _code){
        enemy_code = _code;
    }
    public void Set_enemy_name(string _name){
        enemy_name = _name;
    }
    public void Set_enemy_exp(int _exp){
        enemy_exp = _exp;
    }
    public void Set_enemy_coin(int _coin){
        enemy_coin = _coin;
    }
}
