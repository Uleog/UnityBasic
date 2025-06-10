using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{

    string star;


    void Start()
    {
        star = string.Empty;


        star += "¡Ú"; // º°
        star += "¡¡"; // ºóÄ­
        star += "\n"; // ÁÙ¹Ù²Þ


        Debug.Log(star);

        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;

        for (int i = 1; i <= 5; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }

            Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        int totalRows = 5;

        for(int i = 0; i < totalRows; i++)
        {
            for( int space = 0; space < i; space++)
            {
                star += "¡¡";
            }
            for (int j = 0; j < totalRows - i; j++)
            {
                star += "¡Ú";
            }
            star += "\n";

        }

        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        int totalRows = 4;

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }

        for (int i = totalRows; i >= 1; i--)
        {
            for (int j =1; j <= i; j++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }


        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        int totalRows = 4;

        for (int i = 0; i <= 5; i ++)
        {
            for (int j = 0; j < 5 - i; j++)
            {
                star += "¡¡";
            }
            for (int k =0; k < i; k++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }

        for (int i = 0; i < totalRows; i++)
        {
            for (int space = 0; space < i; space++)
            {
                star += "¡¡";
            }
            for (int j = 0; j < totalRows - i; j++)
            {
                star += "¡Ú";
            }
            star += "\n";

        }
        


        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // ÆäÀÌÁî 5


        Debug.Log(star);
    }
}
