using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Characteristic
{
    Tree
}

public class Crops : MonoBehaviour
{
    [Header("�۹�")]
    [SerializeField] private Characteristic characteristic = Characteristic.Tree; // �⺻�� Tree
    [Header("�ڶ�� �ð�")]
    [SerializeField] private float _GrowUpTime;
    [Header("�� �ڶ� �� ����Ʈ")]
    [SerializeField] GameObject _Effect;


    public bool _Check = false;
    private void Start()
    {
        StartCoroutine(GrowUp());
    }


    IEnumerator GrowUp()
    {
        float current_time = 0f;
        Vector3 origin = transform.localScale;

        while (current_time < _GrowUpTime)
        {
            transform.localScale = new Vector3(origin.x, current_time / _GrowUpTime, origin.z);
            current_time += Time.deltaTime;
            yield return null;
        }
        _Check = true;
        _Effect.SetActive(true);
        yield return null;
    }
}
