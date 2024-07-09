
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace cfg
{
public sealed partial class PlacingSkill : Luban.BeanBase
{
    public PlacingSkill(JSONNode _buf) 
    {
        { if(!_buf["id"].IsNumber) { throw new SerializationException(); }  Id = _buf["id"]; }
        { if(!_buf["skillKind"].IsNumber) { throw new SerializationException(); }  SkillKind = (Battle.PSkillKind)_buf["skillKind"].AsInt; }
        { if(!_buf["target"].IsBoolean) { throw new SerializationException(); }  Target = _buf["target"]; }
        { if(!_buf["conditions"].IsNumber) { throw new SerializationException(); }  Conditions = (Battle.PSkillCondition)_buf["conditions"].AsInt; }
        { if(!_buf["skillId"].IsNumber) { throw new SerializationException(); }  SkillId = _buf["skillId"]; }
    }

    public static PlacingSkill DeserializePlacingSkill(JSONNode _buf)
    {
        return new PlacingSkill(_buf);
    }

    /// <summary>
    /// 摆放技能id
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 摆放技能种类
    /// </summary>
    public readonly Battle.PSkillKind SkillKind;
    /// <summary>
    /// 作用对象 Y自身F其他
    /// </summary>
    public readonly bool Target;
    /// <summary>
    /// 触发条件
    /// </summary>
    public readonly Battle.PSkillCondition Conditions;
    /// <summary>
    /// 技能id
    /// </summary>
    public readonly int SkillId;
   
    public const int __ID__ = 689553613;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "skillKind:" + SkillKind + ","
        + "target:" + Target + ","
        + "conditions:" + Conditions + ","
        + "skillId:" + SkillId + ","
        + "}";
    }
}

}