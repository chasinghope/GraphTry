
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


type BattleTBGoodsProp struct {
    _dataMap map[int32]*GoodsProp
    _dataList []*GoodsProp
}

func NewBattleTBGoodsProp(_buf []map[string]interface{}) (*BattleTBGoodsProp, error) {
    _dataList := make([]*GoodsProp, 0, len(_buf))
    dataMap := make(map[int32]*GoodsProp)

    for _, _ele_ := range _buf {
        if _v, err2 := NewGoodsProp(_ele_); err2 != nil {
            return nil, err2
        } else {
            _dataList = append(_dataList, _v)
            dataMap[_v.Id] = _v
        }
    }
    return &BattleTBGoodsProp{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *BattleTBGoodsProp) GetDataMap() map[int32]*GoodsProp {
    return table._dataMap
}

func (table *BattleTBGoodsProp) GetDataList() []*GoodsProp {
    return table._dataList
}

func (table *BattleTBGoodsProp) Get(key int32) *GoodsProp {
    return table._dataMap[key]
}

