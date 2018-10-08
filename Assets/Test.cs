using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public class Boss
    {
        private int mp = 53;          // 魔力

        // 攻撃用の関数
        public void Magic()
        {
            if (mp >= 5)
            {
                mp = mp - 5;
                Debug.Log("魔法攻撃をした。。残りＭＰは" + this.mp);
            }
            else
            {
                Debug.Log("ＭＰが足りないため魔法が使えない");
            }
        }
    }

    // Use this for initialization
    void Start () {


        int[] array = { 10, 20, 30, 40, 50 };//要素数５の配列arrayの各要素に値を代入する

        for (int i = 0; i < array.Length; i++)
        {
            
                // 配列の要素を表示する
                Debug.Log(array[i]);

        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            
                 //配列の要素を表示する
               Debug.Log(array[i]);
 
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す

        for (int i = 0; i < 11; i++)
        {

            Debug.Log(i);
            lastboss.Magic();
        }


    }

    // Update is called once per frame
    void Update () {
		
	}
}
