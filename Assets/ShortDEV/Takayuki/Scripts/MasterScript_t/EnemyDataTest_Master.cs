using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyDataTest_Master
{
    public string name;
    public int hp;
    public int atk;
    public int exp;
    public int gold;

    //コンストラクタ（必要に応じて追加)
    public EnemyDataTest_Master(string name,int hp,int atk,int exp,int gold)
    {
        this.name=name;
        this.hp=hp;
        this.atk=atk;
        this.exp=exp;
        this.gold=gold;
    }
}

[System.Serializable]
public class EnemyMonsterList{
    public List<EnemyDataTest_Master> monsters; //敵のリスト
}
