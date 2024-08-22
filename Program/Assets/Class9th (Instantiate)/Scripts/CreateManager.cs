using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] int count = 0;

    [SerializeField] GameObject clone;

    [SerializeField] GameObject [] foods;

    WaitForSeconds waitForSeconds = new WaitForSeconds(5.0f);

    private void Start()
    {
        StartCoroutine(Create());
    }

    IEnumerator Create()
    {
        while (count < foods.Length)
        {
            if(clone == null)
            {
                clone = Instantiate(foods[count++]);
            }

            yield return waitForSeconds;
        }
    }

}
