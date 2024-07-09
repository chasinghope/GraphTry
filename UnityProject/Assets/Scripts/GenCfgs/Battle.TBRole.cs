
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
public partial class TBRole
{
    private readonly System.Collections.Generic.Dictionary<int, Role> _dataMap;
    private readonly System.Collections.Generic.List<Role> _dataList;
    
    public TBRole(JSONNode _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Role>();
        _dataList = new System.Collections.Generic.List<Role>();
        
        foreach(JSONNode _ele in _buf.Children)
        {
            Role _v;
            { if(!_ele.IsObject) { throw new SerializationException(); }  _v = Role.DeserializeRole(_ele);  }
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Role> DataMap => _dataMap;
    public System.Collections.Generic.List<Role> DataList => _dataList;

    public Role GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Role Get(int key) => _dataMap[key];
    public Role this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}
