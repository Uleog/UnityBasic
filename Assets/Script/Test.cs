using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{
    int playerLevel = 10;
    void OnEnable()
    {
        Debug.Log("나의 레벨은" + playerLevel + "입니다.");


        Debug.Log($"나의 레벨은 {playerLevel}입니다.");
    }

}
