
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;

type JsonLoader func(string) ([]map[string]interface{}, error)

type Tables struct {
    TBGLConst *BattleTBGLConst
    TBItem *BattleTBItem
    TBRank *BattleTBRank
    TBGoodsProp *BattleTBGoodsProp
    TBGoodsStar *BattleTBGoodsStar
    TBShopRefresh *BattleTBShopRefresh
    TBSeasonRewards *BattleTBSeasonRewards
    TBShopGold *BattleTBShopGold
    TBTreasureBox *BattleTBTreasureBox
    TBTreasureBoxGoods *BattleTBTreasureBoxGoods
    TBRobot *BattleTBRobot
}

func NewTables(loader JsonLoader) (*Tables, error) {
    var err error
    var buf []map[string]interface{}

    tables := &Tables{}
    if buf, err = loader("battle_tbglconst") ; err != nil {
        return nil, err
    }
    if tables.TBGLConst, err = NewBattleTBGLConst(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("battle_tbitem") ; err != nil {
        return nil, err
    }
    if tables.TBItem, err = NewBattleTBItem(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("battle_tbrank") ; err != nil {
        return nil, err
    }
    if tables.TBRank, err = NewBattleTBRank(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("battle_tbgoodsprop") ; err != nil {
        return nil, err
    }
    if tables.TBGoodsProp, err = NewBattleTBGoodsProp(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("battle_tbgoodsstar") ; err != nil {
        return nil, err
    }
    if tables.TBGoodsStar, err = NewBattleTBGoodsStar(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("battle_tbshoprefresh") ; err != nil {
        return nil, err
    }
    if tables.TBShopRefresh, err = NewBattleTBShopRefresh(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("battle_tbseasonrewards") ; err != nil {
        return nil, err
    }
    if tables.TBSeasonRewards, err = NewBattleTBSeasonRewards(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("battle_tbshopgold") ; err != nil {
        return nil, err
    }
    if tables.TBShopGold, err = NewBattleTBShopGold(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("battle_tbtreasurebox") ; err != nil {
        return nil, err
    }
    if tables.TBTreasureBox, err = NewBattleTBTreasureBox(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("battle_tbtreasureboxgoods") ; err != nil {
        return nil, err
    }
    if tables.TBTreasureBoxGoods, err = NewBattleTBTreasureBoxGoods(buf) ; err != nil {
        return nil, err
    }
    if buf, err = loader("battle_tbrobot") ; err != nil {
        return nil, err
    }
    if tables.TBRobot, err = NewBattleTBRobot(buf) ; err != nil {
        return nil, err
    }
    return tables, nil
}

