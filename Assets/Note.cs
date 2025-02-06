using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

//Lesson 4Chapter 3.3　文字列を表示するスクリプトを作ろう
public class Note : MonoBehaviour
{
    //★エラーが出た場合はコンソール画面上でダブルクリックすると該当の行に飛べる

    // Start is called before the first frame update
    void Start()
    {
        //コンソールにHello, Worldと表示
        UnityEngine.Debug.Log("Hello, World");
    }

    // Update is called once per frame
    void Update()
    {

    }
}


//Lesson 4Chapter 4.2　変数を使ってみよう
public class Test2 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //変数の宣言
        int score;
        //変数の代入
        score = 150;
        // 変数の初期化（宣言と代入を1行で記述）→int score = 150;

        //コンソールに変数の中身を表示
        UnityEngine.Debug.Log(score);

        
    }

    // Update is called once per frame
    void Update()
    {

    }
}


//Lesson 4Chapter 4.3　変数を使って計算しよう
public class Test3 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // 変数を初期化する
        int a = 3;
        int b = 4;
        // 変数aと変数bの合計値を変数cに代入する
        int c = a + b;
        // 変数cを表示する　
        UnityEngine.Debug.Log(c);

        //★練習★
        //int a = 3;
        //int b = 4;
        //int c = a + b;
        //int d = b / a;
        //int e= b% a;
        //int num = 8;
        //Debug.Log(c);
        //Debug.Log(d+","+e);
        //Debug.Log(num+=1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}


//Lesson 4Chapter 5.1　if文を使おう　
public class Test4 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // moneyを200で初期化する
        int money = 50;

        if (money >= 100)
        {
            // moneyの値が100以上の場合、文字列を表示する
            UnityEngine.Debug.Log("ポーションを買う");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}


//Lesson 4Chapter 5.2*Chapter 5.3　if〜else文を使おう*if〜else if〜else文を使おう 練習問題
public class Test5 : MonoBehaviour
{
    public int money;
    // Start is called before the first frame update
    void Start()
    {
        int money = 100;
        if (money <= 50)
        {
            UnityEngine.Debug.Log("武器を売る");
        }
        else if (money >= 200)
        {
             UnityEngine.Debug.Log("武器を買う");
        }
        else
        {
            UnityEngine.Debug.Log("ポーションを買う");
        }
    }
     // Update is called once per frame
        void Update()
        {


        }
    }


//Lesson 4Chapter 5.4　三項演算子
public class Test6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int val;
        int num = 1;
        // valに代入する値を条件によって変える(三項演算子)
        //int Val = (num == 1) ? -100 : 100;↓下の構文と同じ意味

        if (num == 1)
        {
            val = -100;
        }
        else
        {
            val = 100;
        }
        UnityEngine.Debug.Log(val);

        // Debug.Log(Val);
        //int a = 3;
        //if (a == 3)
        // {
        //    int b = 5;
        //    Debug.Log(b);
        // }
    }

    // Update is called once per frame
    void Update()
    {


    }
}



//Lesson 4Chapter 6. for文
public class Test7 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // 5回処理を繰り返す
        for (int i = 0; i < 5; i++)
        {
            UnityEngine.Debug.Log(i);
        }
        //for (int j = 0; j < 5; j++)
        //{
        //    Debug.Log(points[j]);
        //}

        // int sum = 0;

        //for (int h = 0; h <=10; h++)
        // {
        //    sum += h;
        //   Debug.Log(sum);
        //}

        //for (int i = 0; i < 6; i++)
        // {
        //   Debug.Log(i);
        //}

    }

    // Update is called once per frame
    void Update()
    {

    }
}


//Lesson 4Chapter 7.1 配列
public class Test8 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] points = new int[5];

        // 配列の各要素に値を代入する
        points[0] = 30;
        points[1] = 20;
        points[2] = 50;
        points[3] = 10;
        points[4] = 80;

        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)
        {
            UnityEngine.Debug.Log(points[i]);
        }
        //int[] points= new int[5];

        //points[0] = 30;
        // points[1] = 20;
        // points[2] = 50;
        // points[3] = 10;
        //points[4] = 80;

        //練習問題
        string[] point = new string[5];

        point[0] = "30";
        point[1] = "20";
        point[2] = "50";
        point[3] = "10";
        point[4] = "80";

        for (int s = 0; s < 5; s++)
        {
            UnityEngine.Debug.Log(point[s]);
        }
        //応用編
        int[] pointt = { 30, 20, 50, 10, 80, 15, 60, 100 };
        for (int j = 0; j < points.Length; j--)
        {
            UnityEngine.Debug.Log(pointt[j]);

        }
        /*配列の表示を逆順にする方法
         * forの前に「Array.Reverse(変数名）」を入れる
         * 参考↓
         * URL：https://dobon.net/vb/dotnet/programing/arrayreverse.html#google_vignette
         */

    }

    // Update is called once per frame
    void Update()
    {

    }
}


//Lesson 4Chapter 8　関数
public class Test9 : MonoBehaviour
{
    //  ★引数＝材料、関数＝マシン、戻り値＝結果

    // void GoodBay()→「void GoodBay」が関数の名前、（）内が材料
    //{
    // Debug.Log("GoodBay,unitychan");//「void GoodBay」が行う作業
    //}
    int Add(int a, int b, int c)
    {
        int d = a + b + c;
        return d;
    }
    void HelloName(int name)
    {
        UnityEngine.Debug.Log(name);
    }

    

    // Start is called before the first frame update
    void Start()
    {
        int num = Add(3, 6, 9);

        UnityEngine.Debug.Log(num);


        HelloName(00);


        // GoodBay();

        

        // Update is called once per frame
        void Update()
        {


        }
    }
}


//★Lesson4　Chapter 9　★
public class Boss1
{
    //public:別のクラスから変数または関数にアクセスできる
    //private:別のクラスから変数または関数にアクセスできない

    private int hp=100; //体力
    private int power=25; //攻撃力

    public　void Attack()
    {
        UnityEngine.Debug.Log(this.power + "のダメージを与えた");//攻撃用の関数

    }
    public void Defence(int damage)//防御用関数
    {
        UnityEngine.Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
        //thisを付けることでこのクラス（Boss）のメンバ変数を使うことを示す
        //※関数・for内の変数はメンバ変数ではなくローカル変数
    }


}

public class Test10: MonoBehaviour
//「：MonoBehaviour」 継承の構文→unityが作成した「MonoBehaviour」というclassで定義された関数・変数を継承する　の意
{
    // Start is called before the first frame update
    void Start()
    {
        Boss1 lastboss = new Boss1();
        lastboss.Attack();
        lastboss.Defence(3);
    }
    void Update()
    {


    }

}

//★Lesson4　Chapter 9　　練習問題★

public class Midboss
{
    public int hp=200;
    public int power=50;
    public void Attack()
    {
        UnityEngine.Debug.Log(power + "のダメージを受けた");
    }
    public void Defence(int damage) {
        UnityEngine.Debug.Log(damage);
        hp -= damage;
        UnityEngine.Debug.Log(damage + "のダメージを与えた");
    }
}

public class Test11 : MonoBehaviour
{
    void Start()
    {
        Boss1 midBoss = new Boss1();
        midBoss.Attack();
        midBoss.Defence(3);



    }
    void Update()
    {

    }
}