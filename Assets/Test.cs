using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 1, 3, 5, 7, 9 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        Array.Reverse(array);
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }



        Boss lastboss= new Boss();
        lastboss.Attak();
        lastboss.Defence(3);
        lastboss.Magic(5);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attak()
    {

        Debug.Log(this.power + "のダメージを与えた");


    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        hp -= damage;

    }

    public void Magic(int magicattak)
    {
        

        for (int j = 0; j <= 11; j++)
        {

            if (mp >= 5)
            {
                mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");

            }
            else
            {
                Debug.Log("MPが足りないため、魔法が使えない。");

            }
      
                if (j > 10)
                {
                    Debug.Log("MPが足りません。");
                }
            }
        
    }
}

