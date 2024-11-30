using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_DB : ScriptableObject
{
    [Header("аж╪р")]
    [SerializeField] public string URL;
    [Header("Sheet Name")]
    [SerializeField] public string SheetName;
    [Header("Option")]
    [SerializeField] public int Read_Start_Column;
    [SerializeField] public int Read_End_Column;
    
}
