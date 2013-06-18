using UnityEngine;
using System.Collections;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System;

public enum XmlDataType
{
    MAI
, // AIsSettings
    MSK
, //BossSkillsSettings
    DRP
, // DropItemsSettings
    MOB
, // EnemiesSettings
    COS
, // ItemCostumesSettings
    ETC
, // ItemEtcsSettings
    PUZ
, // ItemPuzzlePiecesSettings
    SKS
, // ItemSkillStonesSettings
    WAF
, // ItemWarfStonesSettings
    WPN
, // ItemWeaponsSettings
    WUS
, // ItemWeaponStrengthenStonesSettings
    PUB
, // PuzzleBasesSettings
    SLT
, // SkillSlotsSettings
    SKL
, // SkillsSettings
    SKE
, // SkillStonesSettings
    ZON
, // ZonesSettings
}

public enum CurrentLocationInfo
{
    Zone1_1
,
    Zone1_2
,
    Zone1_3
,
}

public class GetXmlData
{
	#region Variables

    public string ResourcePath;
    public CurrentLocationInfo currentLocationInfo = CurrentLocationInfo.Zone1_1;
    public AIsSettings aIsSettings;
    public BossSkillsSettings bossSkillsSettings;
    public DropItemsSettingsZone0101 dropItemsSettingsZone0101;
    public EnemiesSettings enemiesSettings;
    public ItemCostumesSettings itemCostumesSettings;
    public ItemEtcsSettings itemEtcsSettings;
    public ItemPuzzlePiecesSettings itemPuzzlePiecesSettings;
    public ItemSkillStonesSettings itemSkillStonesSettings;
    public ItemWarfStonesSettings itemWarfStonesSettings;
    public ItemWeaponsSettings itemWeaponsSettings;
    public ItemWeaponStrengthenStonesSettings itemWeaponStrengthenStonesSettings;
    public PlayerLevelsSettings playerLevelsSettings;
    public PlayersSettings playersSettings;
    public PuzzleBasesSettings puzzleBasesSettings;
    public SkillSlotsSettings skillSlotsSettings;
    public SkillsSettings skillsSettings;
    public SkillStonesSettings skillStonesSettings;
    public ZonesSettings zonesSettings;
	#region TextAsset Variables

    public TextAsset aIsSettingsText;
    public TextAsset bossSkillsSettingsText;
    public TextAsset dropItemsSettingsZone0101Text;
    public TextAsset enemiesSettingsText;
    public TextAsset itemCostumesSettingsText;
    public TextAsset itemEtcsSettingsText;
    public TextAsset itemPuzzlePiecesSettingsText;
    public TextAsset itemSkillStonesSettingsText;
    public TextAsset itemWarfStonesSettingsText;
    public TextAsset itemWeaponsSettingsText;
    public TextAsset itemWeaponStrengthenStonesSettingsText;
    public TextAsset playerLevelsSettingsText;
    public TextAsset playersSettingsText;
    public TextAsset puzzleBasesSettingsText;
    public TextAsset skillSlotsSettingsText;
    public TextAsset skillsSettingsText;
    public TextAsset skillStonesSettingsText;
    public TextAsset zonesSettingsText;
	#endregion


	#endregion

    public GetXmlData ()
    {
        aIsSettingsText = GetXmlTextAsset ("AIsSettings");
        bossSkillsSettingsText = GetXmlTextAsset ("BossSkillsSettings");
        dropItemsSettingsZone0101Text = GetXmlTextAsset ("DropItemsSettingsZone0101");
        enemiesSettingsText = GetXmlTextAsset ("EnemiesSettings");
        itemCostumesSettingsText = GetXmlTextAsset ("ItemCostumesSettings");
        itemEtcsSettingsText = GetXmlTextAsset ("ItemEtcsSettings");
        itemPuzzlePiecesSettingsText = GetXmlTextAsset ("ItemPuzzlePiecesSettings");
        itemSkillStonesSettingsText = GetXmlTextAsset ("ItemSkillStonesSettings");
        itemWarfStonesSettingsText = GetXmlTextAsset ("ItemWarfStonesSettings");
        itemWeaponsSettingsText = GetXmlTextAsset ("ItemWeaponsSettings");
        itemWeaponStrengthenStonesSettingsText = GetXmlTextAsset ("ItemWeaponStrengthenStonesSettings");

        playerLevelsSettingsText = GetXmlTextAsset ("PlayerLevelsSettings");
        playersSettingsText = GetXmlTextAsset ("PlayersSettings");

        puzzleBasesSettingsText = GetXmlTextAsset ("PuzzleBasesSettings");
        skillSlotsSettingsText = GetXmlTextAsset ("SkillSlotsSettings");
        skillsSettingsText = GetXmlTextAsset ("SkillsSettings");
        skillStonesSettingsText = GetXmlTextAsset ("SkillStonesSettings");

        zonesSettingsText = GetXmlTextAsset ("ZonesSettings");

        GetAllData ();
    }

    public TextAsset GetXmlTextAsset (string file_name)
    {
        var xmlPath = "XmlData/";
        TextAsset ta = (TextAsset)Resources.Load (
            xmlPath + file_name, typeof(TextAsset));
        return ta;
    }

    public void GetAllData ()
    {
        aIsSettings = GetAIsSettings ();
        bossSkillsSettings = GetBossSkillsSettings ();
        dropItemsSettingsZone0101 = GetDropItemsSettingsZone0101 ();

        enemiesSettings = GetEnemiesSettings ();

        itemCostumesSettings = GetItemCostumesSettings ();
        itemEtcsSettings = GetItemEtcsSettings ();
        itemPuzzlePiecesSettings = GetItemPuzzlePiecesSettings ();
        itemSkillStonesSettings = GetItemSkillStonesSettings ();
        itemWarfStonesSettings = GetItemWarfStonesSettings ();
        itemWeaponsSettings = GetItemWeaponsSettings ();
        itemWeaponStrengthenStonesSettings = GetItemWeaponStrengthenStonesSettings ();

        playerLevelsSettings = GetPlayerLevelsSettings ();
        playersSettings = GetPlayersSettings ();

        puzzleBasesSettings = GetPuzzleBasesSettings ();
        skillSlotsSettings = GetSkillSlotsSettings ();
        skillsSettings = GetSkillsSettings ();
        skillStonesSettings = GetSkillStonesSettings ();
        zonesSettings = GetZonesSettings ();
    }
	#region 아이템 목록 얻기

    public AIsSettings GetAIsSettings ()
    {
        XmlSerializer x = new XmlSerializer (typeof(AIsSettings));
        AIsSettings ais = null;
        using (MemoryStream stream = new MemoryStream(aIsSettingsText.bytes)) {
            ais = (AIsSettings)x.Deserialize (stream);
        }
        return ais;
    }

    public BossSkillsSettings GetBossSkillsSettings ()
    {
        XmlSerializer x = new XmlSerializer (typeof(BossSkillsSettings));
        BossSkillsSettings bs = null;
        using (MemoryStream stream = new MemoryStream(bossSkillsSettingsText.bytes)) {
            bs = (BossSkillsSettings)x.Deserialize (stream);
        }
        return bs;
    }

    public DropItemsSettingsZone0101 GetDropItemsSettingsZone0101 ()
    {
        XmlSerializer x = new XmlSerializer (typeof(DropItemsSettingsZone0101));
        DropItemsSettingsZone0101 ds = null;
        using (MemoryStream stream = new MemoryStream(dropItemsSettingsZone0101Text.bytes)) {
            ds = (DropItemsSettingsZone0101)x.Deserialize (stream);
        }
        return ds;
    }

    public EnemiesSettings GetEnemiesSettings ()
    {
        XmlSerializer x = new XmlSerializer (typeof(EnemiesSettings));
        EnemiesSettings es = null;
        using (MemoryStream stream = new MemoryStream(enemiesSettingsText.bytes)) {
            es = (EnemiesSettings)x.Deserialize (stream);
        }
        return es;
    }

    public ItemCostumesSettings GetItemCostumesSettings ()
    {
        XmlSerializer x = new XmlSerializer (typeof(ItemCostumesSettings));
        ItemCostumesSettings ic = null;
        using (MemoryStream stream = new MemoryStream(itemCostumesSettingsText.bytes)) {
            ic = (ItemCostumesSettings)x.Deserialize (stream);
        }
        return ic;
    }

    public ItemEtcsSettings GetItemEtcsSettings ()
    {
        XmlSerializer x = new XmlSerializer (typeof(ItemEtcsSettings));
        ItemEtcsSettings ie = null;
        using (MemoryStream stream = new MemoryStream(itemEtcsSettingsText.bytes)) {
            ie = (ItemEtcsSettings)x.Deserialize (stream);
        }
        return ie;
    }

    public ItemPuzzlePiecesSettings GetItemPuzzlePiecesSettings ()
    {
        XmlSerializer x = new XmlSerializer (typeof(ItemPuzzlePiecesSettings));
        ItemPuzzlePiecesSettings ip = null;
        using (MemoryStream stream = new MemoryStream(itemPuzzlePiecesSettingsText.bytes)) {
            ip = (ItemPuzzlePiecesSettings)x.Deserialize (stream);
        }
        return ip;
    }

    public ItemSkillStonesSettings GetItemSkillStonesSettings ()
    {
        XmlSerializer x = new XmlSerializer (typeof(ItemSkillStonesSettings));
        ItemSkillStonesSettings iss = null;
        using (MemoryStream stream = new MemoryStream(itemSkillStonesSettingsText.bytes)) {
            iss = (ItemSkillStonesSettings)x.Deserialize (stream);
        }
        return iss;
    }

    public ItemWarfStonesSettings GetItemWarfStonesSettings ()
    {
        XmlSerializer x = new XmlSerializer (typeof(ItemWarfStonesSettings));
        ItemWarfStonesSettings iws = null;
        using (MemoryStream stream = new MemoryStream(itemWarfStonesSettingsText.bytes)) {
            iws = (ItemWarfStonesSettings)x.Deserialize (stream);
        }
        return iws;
    }

    public ItemWeaponsSettings GetItemWeaponsSettings ()
    {
        XmlSerializer x = new XmlSerializer (typeof(ItemWeaponsSettings));
        ItemWeaponsSettings iws = null;
        using (MemoryStream stream = new MemoryStream(itemWeaponsSettingsText.bytes)) {
            iws = (ItemWeaponsSettings)x.Deserialize (stream);
        }
        return iws;
    }

    public ItemWeaponStrengthenStonesSettings GetItemWeaponStrengthenStonesSettings ()
    {
        XmlSerializer x = new XmlSerializer (typeof(ItemWeaponStrengthenStonesSettings));
        ItemWeaponStrengthenStonesSettings iws = null;
        using (MemoryStream stream = new MemoryStream(itemWeaponStrengthenStonesSettingsText.bytes)) {
            iws = (ItemWeaponStrengthenStonesSettings)x.Deserialize (stream);
        }
        return iws;
    }

    public PlayerLevelsSettings GetPlayerLevelsSettings ()
    {
        XmlSerializer x = new XmlSerializer (typeof(PlayerLevelsSettings));
        PlayerLevelsSettings pls = null;
        using (MemoryStream stream = new MemoryStream(playerLevelsSettingsText.bytes)) {
            pls = (PlayerLevelsSettings)x.Deserialize (stream);
        }
        return pls;
    }

    public PlayersSettings GetPlayersSettings ()
    {
        XmlSerializer x = new XmlSerializer (typeof(PlayersSettings));
        PlayersSettings ps = null;
        using (MemoryStream stream = new MemoryStream(playersSettingsText.bytes)) {
            ps = (PlayersSettings)x.Deserialize (stream);
        }
        return ps;
    }

    public PuzzleBasesSettings GetPuzzleBasesSettings ()
    {
        XmlSerializer x = new XmlSerializer (typeof(PuzzleBasesSettings));
        PuzzleBasesSettings pbs = null;
        using (MemoryStream stream = new MemoryStream(puzzleBasesSettingsText.bytes)) {
            pbs = (PuzzleBasesSettings)x.Deserialize (stream);
        }
        return pbs;
    }

    public SkillSlotsSettings GetSkillSlotsSettings ()
    {
        XmlSerializer x = new XmlSerializer (typeof(SkillSlotsSettings));
        SkillSlotsSettings sss = null;
        using (MemoryStream stream = new MemoryStream(skillSlotsSettingsText.bytes)) {
            sss = (SkillSlotsSettings)x.Deserialize (stream);
        }
        return sss;
    }

    public SkillsSettings GetSkillsSettings ()
    {
        XmlSerializer x = new XmlSerializer (typeof(SkillsSettings));
        SkillsSettings sss = null;
        using (MemoryStream stream = new MemoryStream(skillsSettingsText.bytes)) {
            sss = (SkillsSettings)x.Deserialize (stream);
        }
        return sss;
    }

    public SkillStonesSettings  GetSkillStonesSettings ()
    {
        XmlSerializer x = new XmlSerializer (typeof(SkillStonesSettings));
        SkillStonesSettings sss = null;
        using (MemoryStream stream = new MemoryStream(skillStonesSettingsText.bytes)) {
            sss = (SkillStonesSettings)x.Deserialize (stream);
        }
        return sss;
    }

    public ZonesSettings  GetZonesSettings ()
    {
        XmlSerializer x = new XmlSerializer (typeof(ZonesSettings));
        ZonesSettings zs = null;
        using (MemoryStream stream = new MemoryStream(zonesSettingsText.bytes)) {
            zs = (ZonesSettings)x.Deserialize (stream);
        }
        return zs;
    }
	#endregion


	#region 특정 아이템 얻기
    public AIsSettingsAI GetAIsSettingsAI (string index)
    {
        var aI = aIsSettings.Items.Where (
            item => item.Index.Equals (index)).FirstOrDefault ();
        return aI;
    }

    public BossSkillsSettingsBossSkill GetBossSkillsSettingsBossSkill (string index)
    {
        var bossSkill = bossSkillsSettings.Items.Where (
            item => item.Index.Equals (index)).FirstOrDefault ();
        return bossSkill;
    }

    public DropItemsSettingsDropItemZone0101 GetDropItemsSettingsDropItemZone0101 (string index)
    {
        var dropItem = dropItemsSettingsZone0101.Items.Where (
            item => item.Index.Equals (index)).FirstOrDefault ();
        return dropItem;
    }

    public EnemiesSettingsEnemy GetEnemiesSettingsEnemy (string name)
    {
        var enemy = enemiesSettings.Items.Where (
            item => item.Name.Equals (name)).FirstOrDefault ();
        return enemy;
    }

    public ItemCostumesSettingsItemCostume GetItemCostumesSettingsItemCostume (string index)
    {
        var itemCostume = itemCostumesSettings.Items.Where (
            item => item.Index.Equals (index)).FirstOrDefault ();
        return itemCostume;
    }

    public ItemEtcsSettingsItemEtc GetItemEtcsSettingsItemEtc (string index)
    {
        var itemEtc = itemEtcsSettings.Items.Where (
            item => item.Index.Equals (index)).FirstOrDefault ();
        return itemEtc;
    }

    public ItemPuzzlePiecesSettingsItemPuzzlePiece GetItemPuzzlePiecesSettingsItemPuzzlePiece (string index)
    {
        var itemPuzzle = itemPuzzlePiecesSettings.Items.Where (
            item => item.Index.Equals (index)).FirstOrDefault ();
        return itemPuzzle;
    }

    public ItemSkillStonesSettingsItemSkillStone GetItemSkillStonesSettingsItemSkillStone (string index)
    {
        var itemSkill = itemSkillStonesSettings.Items.Where (
            item => item.Index.Equals (index)).FirstOrDefault ();
        return itemSkill;
    }

    public ItemWarfStonesSettingsItemWarfStone GetItemWarfStonesSettingsItemWarfStone (string index)
    {
        var itemWarf = itemWarfStonesSettings.Items.Where (
            item => item.Index.Equals (index)).FirstOrDefault ();
        return itemWarf;
    }

    public ItemWeaponsSettingsItemWeapon GetItemWeaponsSettingsItemWeapon (string index)
    {
        var itemWeapon = itemWeaponsSettings.Items.Where (
            item => item.Index.Equals (index)).FirstOrDefault ();
        return itemWeapon;
    }

    public ItemWeaponStrengthenStonesSettingsItemWeaponStrengthenStone GetItemWeaponStrengthenStonesSettingsItemWeaponStrengthenStone (string index)
    {
        var itemWeaponStrengthenStones = itemWeaponStrengthenStonesSettings.Items.Where (
            item => item.Index.Equals (index)).FirstOrDefault ();
        return itemWeaponStrengthenStones;
    }

    public PlayerLevelsSettingsPlayerLevel GetPlayerLevelsSettingsPlayerLevel (string name)
    {
        var playerLevel = playerLevelsSettings.Items.Where (
            item => item.Name.Equals (name)).FirstOrDefault ();
        return playerLevel;
    }

    public PlayersSettingsPlayer GetPlayersSettingsPlayer (string name)
    {
        var player = playersSettings.Items.Where (
            item => item.Name.Equals (name)).FirstOrDefault ();
        return player;
    }

    public PuzzleBasesSettingsPuzzleBase GetPuzzleBasesSettingsPuzzleBase (string index)
    {
        var puzzleBase = puzzleBasesSettings.Items.Where (
            item => item.Index.Equals (index)).FirstOrDefault ();
        return puzzleBase;
    }

    public SkillSlotsSettingsSkillSlot GetSkillSlotsSettingsSkillSlot (string index)
    {
        var skillSlot = skillSlotsSettings.Items.Where (
            item => item.Index.Equals (index)).FirstOrDefault ();
        return skillSlot;
    }

    public SkillsSettingsSkill GetSkillsSettingsSkill (string index)
    {
        var skil = skillsSettings.Items.Where (
            item => item.Index.Equals (index)).FirstOrDefault ();
        return skil;
    }

    public SkillStonesSettingsSkillStone GetSkillStonesSettingsSkillStone (string index)
    {
        var skillStone = skillStonesSettings.Items.Where (
            item => item.Index.Equals (index)).FirstOrDefault ();
        return skillStone;
    }

    public ZonesSettingsZone GetZonesSettingsZone (string index)
    {
        var zone = zonesSettings.Items.Where (
            item => item.Index.Equals (index)).FirstOrDefault ();
        return zone;
    }
	#endregion

    public XmlDataType FindItemType (string name)
    {
        XmlDataType temp_type = (XmlDataType)Enum.Parse (typeof(XmlDataType), name.Substring (0, 3));
        return temp_type;
    }

    public XmlData GetFindItem (string index)
    {
        XmlDataType temp_type = FindItemType (index);
        XmlData xml_data = null;
        switch (temp_type) {
        case XmlDataType.MAI:
            xml_data = (AIsSettingsAI)GetAIsSettingsAI (index);
            break;

        case XmlDataType.MSK:
            xml_data = (BossSkillsSettingsBossSkill)GetBossSkillsSettingsBossSkill (index);
            break;

        case XmlDataType.DRP:
            if (currentLocationInfo == CurrentLocationInfo.Zone1_1) {
                xml_data = (DropItemsSettingsDropItemZone0101)GetDropItemsSettingsDropItemZone0101 (index);
            }
            break;

        case XmlDataType.MOB:
            xml_data = (EnemiesSettingsEnemy)GetEnemiesSettingsEnemy (index);
            break;

        case XmlDataType.COS:
            xml_data = (ItemCostumesSettingsItemCostume)GetItemCostumesSettingsItemCostume (index);
            break;

        case XmlDataType.ETC:
            xml_data = (ItemEtcsSettingsItemEtc)GetItemEtcsSettingsItemEtc (index);
            break;

        case XmlDataType.PUZ:
            xml_data = (ItemPuzzlePiecesSettingsItemPuzzlePiece)GetItemPuzzlePiecesSettingsItemPuzzlePiece (index);
            break;

        case XmlDataType.SKS:
            xml_data = (ItemSkillStonesSettingsItemSkillStone)GetItemSkillStonesSettingsItemSkillStone (index);
            break;

        case XmlDataType.WAF:
            xml_data = (ItemWarfStonesSettingsItemWarfStone)GetItemWarfStonesSettingsItemWarfStone (index);
            break;

        case XmlDataType.WPN:
            xml_data = (ItemWeaponsSettingsItemWeapon)GetItemWeaponsSettingsItemWeapon (index);
            break;

        case XmlDataType.WUS:
            xml_data = (ItemWeaponStrengthenStonesSettingsItemWeaponStrengthenStone)GetItemWeaponStrengthenStonesSettingsItemWeaponStrengthenStone (index);
            break;

        case XmlDataType.PUB:
            xml_data = (PuzzleBasesSettingsPuzzleBase)GetPuzzleBasesSettingsPuzzleBase (index);
            break;

        case XmlDataType.SLT:
            xml_data = (SkillSlotsSettingsSkillSlot)GetSkillSlotsSettingsSkillSlot (index);
            break;

        case XmlDataType.SKL:
            xml_data = (SkillsSettingsSkill)GetSkillsSettingsSkill (index);
            break;

        case XmlDataType.SKE:
            xml_data = (SkillStonesSettingsSkillStone)GetSkillStonesSettingsSkillStone (index);
            break;

        case XmlDataType.ZON:
            xml_data = (ZonesSettingsZone)GetZonesSettingsZone (index);
            break;

        default:
            break;
        }

        return xml_data;
    }

    public bool IsCashItem (string index)
    {
        bool result = false;

        if (index.Equals ("ETC_006")) {
            result = true;
        }

        return result;
    }
}
