using GoogleSheetsToUnity;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public struct CropsDB
{
    public string Name;
    int type;
    [TextArea]public string Description;
    public int GrowTime;
    public int Gold;

    public CropsDB(string name, int type, string description, int growTime, int gold)
    {
        this.Name = name;
        this.type = type;
        this.Description = description;
        this.GrowTime = growTime;
        this.Gold = gold;
    }
}



[CreateAssetMenu(fileName = "CropsDB", menuName = "DB Reader/Crops", order = 0)]
public class CropsReader : Base_DB
{
    [SerializeField] public List<CropsDB> item = new List<CropsDB>();
    internal void UpdateStats(List<GSTU_Cell> list)
    {
        string Name = "";
        string Description = "";
        int type = 0;
        int GrowTime = 0;
        int Gold = 0;
        for (int i = 0; i < list.Count; i++)
        {
            switch (list[i].columnId)
            {
                case "이름": Name = list[i].value; break;
                case "타입": type = int.Parse(list[i].value); break;
                case "자라는 시간": GrowTime = int.Parse(list[i].value); break;
                case "가격": Gold = int.Parse(list[i].value); break;
                case "설명": Description = list[i].value; break;

            }

        }
        item.Add(new CropsDB(Name,type,Description,GrowTime,Gold));
    }
}

#if UNITY_EDITOR
public abstract class BaseDataEditor<T> : Editor where T : Base_DB
{
    protected T data;
    protected void Read(UnityAction<GstuSpreadSheet> callback, bool MergedCell = false)
    {
        SpreadsheetManager.Read(new GSTU_Search(data.URL, data.SheetName), callback, MergedCell);
    }

    protected abstract void Parameter(GstuSpreadSheet x);
    protected abstract void ClearData();

    protected void OnEnable() => data = (T)target;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("불러오기"))
        {
            Read(Parameter);
            ClearData();
        }
    }
}
#endif

#if UNITY_EDITOR
[CustomEditor(typeof(CropsReader))]
public class CropsReaderSub : BaseDataEditor<CropsReader>
{
    protected override void Parameter(GstuSpreadSheet x)
    {
        for (int i = data.Read_Start_Column; i <= data.Read_End_Column; ++i)
        {
            data.UpdateStats(x.rows[i]);
        }
        EditorUtility.SetDirty(target);
    }
    protected override void ClearData() => data.item.Clear();

}
#endif

