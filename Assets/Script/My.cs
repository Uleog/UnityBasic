using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class My : MonoBehaviour
{
    private string myName = "김태현";
    private int age = 98;
    private float height = 179.5f;
    private string where = "서울";
    private string where2 = "동대문구";
    private string where3 = "청량리";
    private string eat = "고기";
    private string eat2 = "빵";
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
        Debug.Log("안녕하세요" + myName + "입니다.");
        Debug.Log($"나이는 {age}년 이고");
        Debug.Log("mbti는" + mbti + "입니다.");
    }

    public void SelfIntriduction(float _height, string _where, string _where2, string _where3)
    {
        Debug.Log("키는" + _height + "이고");
        Debug.Log($"사는 곳은 {_where} 특별시");
        Debug.Log("" + _where2 + "");
        Debug.Log($"{_where3}입니다.");
    }

    public void SelfIntriduction(string _eat, string _eat2, int _money)
    {
        Debug.Log("좋아 하는 음식은" + _eat + "랑");
        Debug.Log($"{_eat2}아주 좋아 합니다");
        Debug.Log("덕분에 통장에 돈이" + _money + "원 이에요 ㅠㅠ");
    }


}
