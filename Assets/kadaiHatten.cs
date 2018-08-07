using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    public int mp = 53; // MP

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    public int Magic(int MP)
    {

        if (MP >= 5)
        {
            MP -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + MP);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。残りMPは" + MP);
        }

        return MP;
    }
}



public class kadaiHatten : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        Boss magicBoss = new Boss();
        int currentMP = magicBoss.mp;

        Debug.Log("1回目");
        currentMP = magicBoss.Magic(currentMP);


        for (int i = 0; i < 9; i++)
        {
            Debug.Log((i + 2) + "回目");
            currentMP = magicBoss.Magic(currentMP);
        };

        Debug.Log("11回目");
        magicBoss.Magic(currentMP);

        Debug.Log("12回目");
        magicBoss.Magic(currentMP);

    }

}