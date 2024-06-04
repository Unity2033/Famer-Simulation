using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public int coin;

    private void Awake()
    {
        Load();
    }

    public void Load()
    {
        coin = PlayerPrefs.GetInt("Coin");
    }

    public void SetData()
    {
        coin += 100;
        PlayerPrefs.SetInt("Coin", coin);
    }

}
