
using UnityEngine;

public class Game : MonoBehaviour
{

    [SerializeField] Transform _PlantTransform;
    [SerializeField] GameObject _AreaCheck;
    [SerializeField] GameObject[] SeedPrefab;
    public void Seeding_AreaCheck()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane Ground = new Plane(Vector3.up, Vector3.zero);
        if (Ground.Raycast(ray, out float distance))
        {
            Vector3 worldPos = ray.GetPoint(distance);
            GameObject _obj = Instantiate(_AreaCheck, worldPos, Quaternion.identity);
            _obj.transform.SetParent(transform);
        }
    }
    public bool Seeding()
    {
        if(Crop_Area_Check.Instance.buildingcheck == false)
        {
            Debug.Log("불가능 합니다.");
            return false;
        }
        else
        {
            Crop_Area_Check.Instance.PlantCreate(Characteristic.Tree,_PlantTransform, SeedPrefab[0]);
            return true;
        }
    }
}
