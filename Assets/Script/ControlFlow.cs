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
        int number = 0; //����

        while (number < 5) //����
        {
            number++;//�ݺ�
        }

        for (int i = 0; i<10; i++) // ����, ����, �ݺ�
        {

        }



        while(number < 10)
        {
            int randomValue = Random.Range(1, 101);

            Debug.Log($"������ ����  : {randomValue} �Դϴ�");

            if (8 <= count)
            {
                count = 0;
                Debug.Log("'ī��Ƽ�þ�'�� �̾Ҵ�!");
            }

            else if (randomValue <= 10) // 1~10 -> 10%
            {
                Debug.Log("'ī��Ƽ�þ�'�� �̾Ҵ�!");
            }
            else if (randomValue <= 20) // 11~20
            {
                Debug.Log("'����'�� �̾Ҵ�!");
            }
            else if (randomValue <= 30) // 21~30
            {
                Debug.Log("'����'�� �̾Ҵ�!");
            }
            else if (randomValue <= 40) // 31~40
            {
                Debug.Log("'ġ��'�� �̾Ҵ�!");
            }
            else
            {
                Debug.Log("'����'�� �̾Ҵ�!");
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
                Debug.Log("'��� �Ӹ�'�� �̾Ҵ�!");
                break;

            case 1:
                Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
                break;

            case 2:
                Debug.Log("'����ȫ �Ӹ�'�� �̾Ҵ�!");
                break;

            case 3:
                Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
                break;

            case 4:
                Debug.Log("'�ʷ� �׳�'�� �̾Ҵ�!");
                break;

            default:
                break;
        }
    }
    
    
}

