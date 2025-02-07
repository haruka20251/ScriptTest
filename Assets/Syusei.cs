using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syusei : MonoBehaviour
{

     RBoss boss = new RBoss();


    void MagicAttak()
    {
      boss.Magicattak(5);
      int mp = boss.magicpoint;
 
     
    }

    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 1, 3, 5, 7, 9 };
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);

        }

        for (int j = array.Length - 1; j >= 0; j--)
        {
            Debug.Log(array[j]);
        }

        boss.Attak();
        boss.Damage(3);

        for (int p = 0; p <= 9; p++)
        {
            MagicAttak();
            if (p == 9)
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
                Debug.Log("MPが足りません。");

            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class RBoss
    {
        int hitpoint = 200;
        public int magicpoint = 53;
        int attak = 25;

        public void Attak()
        {
            Debug.Log(this.attak + "のダメージを与えた");
        }
        public void Damage(int damage)
        {
            hitpoint -= damage;
            Debug.Log(damage + "のダメージを受けた");

        }
        public void Magicattak(int magicattak)
        {
            if (magicattak > 0)
            {
                magicpoint -= magicattak;
                Debug.Log("魔法攻撃をした。残りMPは" + magicpoint + "。");
            }



        }

    }
}