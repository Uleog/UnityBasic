using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class My : MonoBehaviour
{
    private string myName = "������";
    private int age = 98;
    private float height = 179.5f;
    private string where = "����";
    private string where2 = "���빮��";
    private string where3 = "û����";
    private string eat = "���";
    private string eat2 = "��";
    private string mbti = "infp";
    private int money = 0;



    void Start()
    {
        SelfIntriduction();
        SelfIntriduction(height, where, where2, where3);
        SelfIntriduction(eat, eat2, money);
    }

    public void SelfIntriduction()
    {
        Debug.Log("�ȳ��ϼ���" + myName + "�Դϴ�.");
        Debug.Log($"���̴� {age}�� �̰�");
        Debug.Log("mbti��" + mbti + "�Դϴ�.");
    }

    public void SelfIntriduction(float _height, string _where, string _where2, string _where3)
    {
        Debug.Log("Ű��" + _height + "�̰�");
        Debug.Log($"��� ���� {_where} Ư����");
        Debug.Log("" + _where2 + "");
        Debug.Log($"{_where3}�Դϴ�.");
    }

    public void SelfIntriduction(string _eat, string _eat2, int _money)
    {
        Debug.Log("���� �ϴ� ������" + _eat + "��");
        Debug.Log($"{_eat2}���� ���� �մϴ�");
        Debug.Log("���п� ���忡 ����" + _money + "�� �̿��� �Ф�");
    }


}
