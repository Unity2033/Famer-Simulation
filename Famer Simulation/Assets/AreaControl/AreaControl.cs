using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class AreaControl : MonoBehaviour
{
    [Header("범위")]
    [SerializeField] float _scope;


    private SphereCollider _Area;

    private GameObject my;
    private EventSystemControl script;


    [SerializeField] int _Key;
    [SerializeField] Dictionary<int, Action> _dictionary = new Dictionary<int, Action>();


#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, _scope);
    }
#endif

    void Start()
    {
        _Area = GetComponent<SphereCollider>();
        _Area.radius = _scope;
        _Area.isTrigger = true;

        GameObject player = GameObject.FindGameObjectWithTag("Player");

        
        _dictionary[_Key] = () =>
        {
            switch (_Key)
            {
                default:
                    break;
            }
        };




    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (_dictionary.ContainsKey(_Key))
            {

            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (_dictionary.ContainsKey(_Key))
            {

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (_dictionary.ContainsKey(_Key))
            {

            }
        }
    }



    // EventSystem관련

    public void TotalDestory()
    {
        Destroy(my);
        Destroy(gameObject);
    }

    public void UpdateEventSystem(bool b, string str = null, string str2 = null)
    {

        if (my == null)
        {
            my = TotalUiControl._instance.Create(TotalUiControl.Type.EventSystem);
            my.transform.SetAsFirstSibling(); // 맨 위로 가서 Ui와 겹치지 않게 하기 위함
            script = my.GetComponent<EventSystemControl>();
            script.Init(transform, str, str2);
        }
        else if (b == true) script.Change_Text(str, str2);
        script.OnOff(b);
    }
}
*/