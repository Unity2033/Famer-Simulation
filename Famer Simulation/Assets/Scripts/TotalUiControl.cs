using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalUiControl : MonoSingletonManager<TotalUiControl>
{


    [Header("UI 표시 Object")]
    [Space(10)]
    [Header("원하는 key를 누르세요 Prefab")]
    [SerializeField] private GameObject _EventSystem;



    public enum Type
    {
        EventSystem = 0,
        ItemDescription,
        SkillDescription
    }

    public GameObject Create(Type type)
    {
        GameObject obj = null;
        switch (type)
        {
            case Type.EventSystem:
                obj = Instantiate(_EventSystem, transform);
                break;
        }
        return obj;
    }



}
