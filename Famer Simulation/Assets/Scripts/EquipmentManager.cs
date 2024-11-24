using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
    [SerializeField] Transform parentTransform;
    [SerializeField] Equipment currentEquipment;

    [SerializeField] Equipment [ ] equipments;

    [SerializeField] Vector3 direction;

    int count = 0;

    private void Start()
    {
        direction = new Vector3(0, 0, transform.position.z + 10);
    }

    public void SelectEquipment(Equipment equipment)
    {
        if (currentEquipment == null)
        {
            currentEquipment = equipment;

            currentEquipment.transform.SetParent(parentTransform);

            currentEquipment.transform.localPosition = parentTransform.position;
        }
        else
        {
            currentEquipment.transform.SetParent(null);

            currentEquipment.transform.position = direction;

            currentEquipment = equipment;

            currentEquipment.transform.SetParent(parentTransform);

            currentEquipment.transform.localPosition = parentTransform.position;
        }

        currentEquipment.Use();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SelectEquipment(equipments[count++ % equipments.Length]);
        }
    }
}
