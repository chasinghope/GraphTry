
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


type BattleTBTreasureBoxGoods struct {
    _dataMap map[int32]*TreasureBoxGoods
    _dataList []*TreasureBoxGoods
}

func NewBattleTBTreasureBoxGoods(_buf []map[string]interface{}) (*BattleTBTreasureBoxGoods, error) {
    _dataList := make([]*TreasureBoxGoods, 0, len(_buf))
    dataMap := make(map[int32]*TreasureBoxGoods)

    for _, _ele_ := range _buf {
        if _v, err2 := NewTreasureBoxGoods(_ele_); err2 != nil {
            return nil, err2
        } else {
            _dataList = append(_dataList, _v)
            dataMap[_v.Id] = _v
        }
    }
    return &BattleTBTreasureBoxGoods{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *BattleTBTreasureBoxGoods) GetDataMap() map[int32]*TreasureBoxGoods {
    return table._dataMap
}

func (table *BattleTBTreasureBoxGoods) GetDataList() []*TreasureBoxGoods {
    return table._dataList
}

func (table *BattleTBTreasureBoxGoods) Get(key int32) *TreasureBoxGoods {
    return table._dataMap[key]
}


