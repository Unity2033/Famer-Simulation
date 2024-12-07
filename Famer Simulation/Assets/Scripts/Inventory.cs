using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject item;
    [SerializeField] GameObject [ ] itemTransform;
    [SerializeField] GameObject[] itemList;  



    public void Collect(GameObject equipment)
    { 
        for(int i = 0; i < itemTransform.Length; i++)
        {
            if (itemTransform[i].transform.childCount == 0)
            {
                itemList[i] = Instantiate(item, itemTransform[i].transform);

                itemList[i].GetComponent<Image>().sprite = Resources.Load<Sprite>(equipment.name);

                itemList[i].name = equipment.name;

                break;
            }

        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Collect(item);
        }
    }
}
