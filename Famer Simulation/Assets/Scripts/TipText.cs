using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "TipText",menuName = "TipText")]
public class TipText : ScriptableObject
{
    [SerializeField] List<string> tipList = new List<string>();

    public string LoadTip(int num)
    {
        if (num <= -1)
            return tipList[Random.Range(0, tipList.Count)];

        if (tipList.Count <= num)
            return tipList[num];

        return null;
    }
}
