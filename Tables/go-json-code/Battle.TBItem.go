
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


type BattleTBItem struct {
    _dataMap map[int32]*Item
    _dataList []*Item
}

func NewBattleTBItem(_buf []map[string]interface{}) (*BattleTBItem, error) {
    _dataList := make([]*Item, 0, len(_buf))
    dataMap := make(map[int32]*Item)

    for _, _ele_ := range _buf {
        if _v, err2 := NewItem(_ele_); err2 != nil {
            return nil, err2
        } else {
            _dataList = append(_dataList, _v)
            dataMap[_v.Id] = _v
        }
    }
    return &BattleTBItem{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *BattleTBItem) GetDataMap() map[int32]*Item {
    return table._dataMap
}

func (table *BattleTBItem) GetDataList() []*Item {
    return table._dataList
}

func (table *BattleTBItem) Get(key int32) *Item {
    return table._dataMap[key]
}


