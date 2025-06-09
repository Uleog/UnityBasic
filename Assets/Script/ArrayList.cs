using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ArrayList : MonoBehaviour
{
    string[] character = { "의현", "리카온", "리나", "11호", "네코마타", "콜레다", "그레이스", "3성 엔진" };
    List<string> charcterList = new List<string>();

    int count;



    private void Awake()
    {
        count = 0;
    }

    public void TenGacha()
    {
        

        int randomValu = Random.Range(0, character.Length);

        Debug.Log(" 'character[randomValue]'");
       

        for (int i =0; i<10; i++)
        {
            int randomValue = Random.Range(1, 101);

            Debug.Log($"랜덤한 값은 : {randomValue} 이다");

            if (50 <= count)
            {
                count = 0;
                Debug.Log("픽업 캐릭터'의현'을 뽑았다.");
            }

            else if (randomValue <= 5)
            {
                Debug.Log("픽업 캐릭터'의현'을 뽑았다!");
            }
            else if (randomValue <= 12)
            {
                Debug.Log("상시 캐릭터'리카온'을 뽑았다!");
            }
            else if (randomValue <= 19)
            {
                Debug.Log("상시 캐릭터'리나'을 뽑았다!");
            }
            else if (randomValue <= 26)
            {
                Debug.Log("상시 캐릭터'11호'을 뽑았다!");
            }
            else if (randomValue <= 33)
            {
                Debug.Log("상시 캐릭터'네코마타'을 뽑았다!");
            }
            else if (randomValue <= 40)
            {
                Debug.Log("상시 캐릭터'콜레다'을 뽑았다!");
            }
            else if (randomValue <= 47)
            {
                Debug.Log("상시 캐릭터'그레이스'을 뽑았다!");
            }
            else
            {
                Debug.Log("'3성 엔진'이 나왔다...");
            }

            count++;
        }



    }    
    
}
