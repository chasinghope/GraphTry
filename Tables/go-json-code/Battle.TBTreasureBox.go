
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


type BattleTBTreasureBox struct {
    _dataMap map[int32]*TreasureBox
    _dataList []*TreasureBox
}

func NewBattleTBTreasureBox(_buf []map[string]interface{}) (*BattleTBTreasureBox, error) {
    _dataList := make([]*TreasureBox, 0, len(_buf))
    dataMap := make(map[int32]*TreasureBox)

    for _, _ele_ := range _buf {
        if _v, err2 := NewTreasureBox(_ele_); err2 != nil {
            return nil, err2
        } else {
            _dataList = append(_dataList, _v)
            dataMap[_v.RankId] = _v
        }
    }
    return &BattleTBTreasureBox{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *BattleTBTreasureBox) GetDataMap() map[int32]*TreasureBox {
    return table._dataMap
}

func (table *BattleTBTreasureBox) GetDataList() []*TreasureBox {
    return table._dataList
}

func (table *BattleTBTreasureBox) Get(key int32) *TreasureBox {
    return table._dataMap[key]
}

