using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    int count;

    void Awake()
    {
        count = 0;
    }


    public void Gacha()
    {
        int number = 0; //변수

        while (number < 5) //조건
        {
            number++;//반복
        }

        for (int i = 0; i<10; i++) // 변수, 조건, 반복
        {

        }



        while(number < 10)
        {
            int randomValue = Random.Range(1, 101);

            Debug.Log($"랜덤한 값은  : {randomValue} 입니다");

            if (8 <= count)
            {
                count = 0;
                Debug.Log("'카르티시아'을 뽑았다!");
            }

            else if (randomValue <= 10) // 1~10 -> 10%
            {
                Debug.Log("'카르티시아'을 뽑았다!");
            }
            else if (randomValue <= 20) // 11~20
            {
                Debug.Log("'샤콘'을 뽑았다!");
            }
            else if (randomValue <= 30) // 21~30
            {
                Debug.Log("'루파'을 뽑았다!");
            }
            else if (randomValue <= 40) // 31~40
            {
                Debug.Log("'치사'을 뽑았다!");
            }
            else
            {
                Debug.Log("'감심'을 뽑았다!");
            }

            count++;
            number++;

        }

       




    }

    public int selectNumbe = 5;
    public void GachaSwitch()
    {
        int randomValue = Random.Range(1, 101);

        int selectNumbe = 0;

        switch (selectNumbe)
        {
            case 0:
                Debug.Log("'노란 머리'을 뽑았다!");
                break;

            case 1:
                Debug.Log("'빨간 머리'을 뽑았다!");
                break;

            case 2:
                Debug.Log("'연분홍 머리'을 뽑았다!");
                break;

            case 3:
                Debug.Log("'검은 머리'을 뽑았다!");
                break;

            case 4:
                Debug.Log("'초록 그녀'을 뽑았다!");
                break;

            default:
                break;
        }
    }
    
    
}

