using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ArrayList : MonoBehaviour
{
    string[] character = { "����", "��ī��", "����", "11ȣ", "���ڸ�Ÿ", "�ݷ���", "�׷��̽�", "3�� ����" };
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

            Debug.Log($"������ ���� : {randomValue} �̴�");

            if (50 <= count)
            {
                count = 0;
                Debug.Log("�Ⱦ� ĳ����'����'�� �̾Ҵ�.");
            }

            else if (randomValue <= 5)
            {
                Debug.Log("�Ⱦ� ĳ����'����'�� �̾Ҵ�!");
            }
            else if (randomValue <= 12)
            {
                Debug.Log("��� ĳ����'��ī��'�� �̾Ҵ�!");
            }
            else if (randomValue <= 19)
            {
                Debug.Log("��� ĳ����'����'�� �̾Ҵ�!");
            }
            else if (randomValue <= 26)
            {
                Debug.Log("��� ĳ����'11ȣ'�� �̾Ҵ�!");
            }
            else if (randomValue <= 33)
            {
                Debug.Log("��� ĳ����'���ڸ�Ÿ'�� �̾Ҵ�!");
            }
            else if (randomValue <= 40)
            {
                Debug.Log("��� ĳ����'�ݷ���'�� �̾Ҵ�!");
            }
            else if (randomValue <= 47)
            {
                Debug.Log("��� ĳ����'�׷��̽�'�� �̾Ҵ�!");
            }
            else
            {
                Debug.Log("'3�� ����'�� ���Դ�...");
            }

            count++;
        }



    }    
    
}
