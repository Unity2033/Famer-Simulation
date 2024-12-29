using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaControl : MonoBehaviour
{
    [Header("����")]
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
                case 1:// ��Ȯ�� ���� Enter
                    UpdateEventSystem(true, "��Ȯ�� �Ͻ÷���", "[E]");
                    if (player != null)
                    {
                        player.GetComponent<Player_Control>().seed = gameObject;
                    }
                    break;

                case 2:// ��Ȯ�� ���� Exit
                    UpdateEventSystem(false);
                    if (player != null)
                    {
                        player.GetComponent<Player_Control>().seed = null;
                    }
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



    // EventSystem����

    public void TotalDestory()
    {
        Destroy(my);
        Destroy(gameObject);
    }

    public void UpdateEventSystem(bool b, string str = null, string str2 = null)
    {

        if (my == null)
        {
            my = TotalUiControl.Instance.Create(TotalUiControl.Type.EventSystem);
            my.transform.SetAsFirstSibling(); // �� ���� ���� Ui�� ��ġ�� �ʰ� �ϱ� ����
            script = my.GetComponent<EventSystemControl>();
            script.Init(transform, str, str2);
        }
        else if (b == true) script.Change_Text(str, str2);
        script.OnOff(b);
    }
}
