using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Tile
{
    None,
    Ground,
    Farm,
    Crops
}
public class Crop_Area_Check : MonoSingletonManager<Crop_Area_Check>
{



    [SerializeField] Material _OK;
    [SerializeField] Material _NO;
    [SerializeField]  private List<GameObject> _list = new List<GameObject>();

    private Renderer _body;
    private Transform _GroundPos;
    public bool buildingcheck = false;

    private Tile _currentTile = Tile.None;
    
    void Start()
    {
        _body = GetComponent<Renderer>();
  
        UpdateState();
    }

     void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane Ground = new Plane(Vector3.up, Vector3.zero);
        if (Ground.Raycast(ray, out float dis))
        {
            Vector3 pos = ray.GetPoint(dis);
            transform.position = new Vector3(pos.x, transform.position.y, pos.z);
        }
        if (_list.Count < 1) transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
    }



    public void PlantCreate(Characteristic type, Transform Parent, GameObject Prefab)
    {

        if (Prefab == null) Debug.Log("[Crop_Area_Check.cs - PlatnCreate] GameObject Nulling Error");
        GameObject obj = Instantiate(Prefab);
        obj.transform.SetParent(Parent);
        obj.transform.position = transform.position;
        Destroy(gameObject);
    }



    public void UpdatePos()
    {

        Vector3 NewPos = transform.position;
        NewPos.y = _GroundPos.position.y + transform.localScale.y;
        transform.position = NewPos;
    }


    public void UpdateState() {

        if (_list.Count > 1 || _list.Count <=  0)
        {
            _body.material = _NO;
            buildingcheck = false;
        }
        else
        {
            _body.material = _OK;
            buildingcheck = true;
        }
    }


    bool Check(Collider other)
    {
        if (!(other.CompareTag("Crops")|| other.CompareTag("Farm"))) return false;
        return true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (Check(other)) {  _list.Add(other.gameObject); UpdateState(); }
    }

    private void OnTriggerExit(Collider other)
    {
        if (Check(other)) { 
            _list.Remove(other.gameObject);
            UpdateState();
            _currentTile = Tile.None;

        }
    }
    private void OnTriggerStay(Collider other)
    {

        // 우선순위는 위부터 높음
        switch (other.tag)
        {
            case "Crops":
                _currentTile = Tile.Crops;
                _body.material = _NO;
                buildingcheck = false;
                break;
            case "Farm":
                if(_currentTile != Tile.Crops)
                {
                    _GroundPos = other.transform;
                    _currentTile = Tile.Farm;

                }
                break;
            case "Untagged":
                if(_currentTile == Tile.None)
                {
                    _GroundPos = other.transform;
                }
                break;

               
        }
        UpdatePos();

    }


}
