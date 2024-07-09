
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace cfg.Battle
{
public partial class TBPlacingSkill
{
    private readonly System.Collections.Generic.Dictionary<int, PlacingSkill> _dataMap;
    private readonly System.Collections.Generic.List<PlacingSkill> _dataList;
    
    public TBPlacingSkill(JSONNode _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, PlacingSkill>();
        _dataList = new System.Collections.Generic.List<PlacingSkill>();
        
        foreach(JSONNode _ele in _buf.Children)
        {
            PlacingSkill _v;
            { if(!_ele.IsObject) { throw new SerializationException(); }  _v = PlacingSkill.DeserializePlacingSkill(_ele);  }
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, PlacingSkill> DataMap => _dataMap;
    public System.Collections.Generic.List<PlacingSkill> DataList => _dataList;

    public PlacingSkill GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public PlacingSkill Get(int key) => _dataMap[key];
    public PlacingSkill this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

