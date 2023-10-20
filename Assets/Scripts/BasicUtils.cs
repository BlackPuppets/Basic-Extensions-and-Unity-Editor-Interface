using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BasicUtils
{
    
    public static T GetRandom<T>(List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }

    public static Color GetRandomColor()
    {
        return Random.ColorHSV(0f, 1f, 0f, 1f, 0f, 1f);
    }

    public static Color GetRandomTransparentColor()
    {
        return Random.ColorHSV(0f, 1f, 0f, 1f, 0f, 1f, 0f, 1f);
    }

}
