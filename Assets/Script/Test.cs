using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{
    int playerLevel = 10;
    void OnEnable()
    {
        Debug.Log("���� ������" + playerLevel + "�Դϴ�.");


        Debug.Log($"���� ������ {playerLevel}�Դϴ�.");
    }

}
