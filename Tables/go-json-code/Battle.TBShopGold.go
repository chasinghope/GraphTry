
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


type BattleTBShopGold struct {
    _dataMap map[int32]*ShopGold
    _dataList []*ShopGold
}

func NewBattleTBShopGold(_buf []map[string]interface{}) (*BattleTBShopGold, error) {
    _dataList := make([]*ShopGold, 0, len(_buf))
    dataMap := make(map[int32]*ShopGold)

    for _, _ele_ := range _buf {
        if _v, err2 := NewShopGold(_ele_); err2 != nil {
            return nil, err2
        } else {
            _dataList = append(_dataList, _v)
            dataMap[_v.Id] = _v
        }
    }
    return &BattleTBShopGold{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *BattleTBShopGold) GetDataMap() map[int32]*ShopGold {
    return table._dataMap
}

func (table *BattleTBShopGold) GetDataList() []*ShopGold {
    return table._dataList
}

func (table *BattleTBShopGold) Get(key int32) *ShopGold {
    return table._dataMap[key]
}

