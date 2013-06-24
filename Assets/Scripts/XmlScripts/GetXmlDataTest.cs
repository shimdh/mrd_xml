using UnityEngine;
using System.Collections;
using System;

public class GetXmlDataTest : UUnitTestCase
{
	public GetXmlData getXmlData;

	protected override void SetUp ()
	{
		getXmlData = new GetXmlData ();
	}
	#region 아이템들 얻기
	[UUnitTest]
    public void TestAIsSettings ()
	{
		UUnitAssert.Equals ("MSK_001",
		                    getXmlData.aIsSettings.Items [0].SkillFirstCheck);
	}

	[UUnitTest]
	public void TestBossSkillsSettings ()
	{
		UUnitAssert.Equals (0.0,
		                    getXmlData.bossSkillsSettings.Items [0].SkillType);
	}

	[UUnitTest]
	public void TestCostumeBasesSettings ()
	{
		UUnitAssert.Equals (0.0,
		                    getXmlData.costumeBasesSettings.Items [0].Cash);
	}

	[UUnitTest]
	public void TestDropItemsSettingsZone0101 ()
	{
		UUnitAssert.Equals ("WUS_001",
		                    getXmlData.dropItemsSettingsZone0101.Items [0].ItemIndex_1);
	}

	[UUnitTest]
	public void TestEnemiesSettings ()
	{
		UUnitAssert.Equals (1.0,
		                    getXmlData.enemiesSettings.Items [0].Level);
	}

	[UUnitTest]
	public void TestItemCostumesSettings ()
	{
		UUnitAssert.Equals (0.0,
		                    getXmlData.itemCostumesSettings.Items [0].HelmetType);
	}

	[UUnitTest]
	public void TestItemEtcsSettings ()
	{
		UUnitAssert.Equals ("ETC_001",
		                    getXmlData.itemEtcsSettings.Items [0].Index);
	}

	[UUnitTest]
	public void TestItemPuzzlePiecesSettings ()
	{
		UUnitAssert.Equals (1.0,
		                    getXmlData.itemPuzzlePiecesSettings.Items [0].PieceLocation);
	}

	[UUnitTest]
	public void TestItemSkillStonesSettings ()
	{
		UUnitAssert.Equals ("SKS_A01",
		                    getXmlData.itemSkillStonesSettings.Items [0].Index);
	}

	[UUnitTest]
	public void TestItemWarfStonesSettings ()
	{
		UUnitAssert.Equals ("WAF_011",
		                    getXmlData.itemWarfStonesSettings.Items [0].Index);
	}

	[UUnitTest]
	public void TestItemWeaponsSettings ()
	{
		UUnitAssert.Equals ("WPN_001",
		                    getXmlData.itemWeaponsSettings.Items [0].Index);
	}

	[UUnitTest]
	public void TestItemWeaponStrengthenStonesSettings ()
	{
		UUnitAssert.Equals ("WUS_001",
		                    getXmlData.itemWeaponStrengthenStonesSettings.Items [0].Index);
	}

	[UUnitTest]
	public void TestPlayerLevelsSettings ()
	{
		UUnitAssert.Equals ("Level1",
		                    getXmlData.playerLevelsSettings.Items [0].Name);
	}

	[UUnitTest]
	public void TestPlayersSettings ()
	{
		UUnitAssert.Equals ("Player1",
		                    getXmlData.playersSettings.Items [0].Name);
	}

	[UUnitTest]
	public void TestPuzzleBasesSettings ()
	{
		UUnitAssert.Equals ("PUB_012",
		                    getXmlData.puzzleBasesSettings.Items [0].Index);
	}

	[UUnitTest]
	public void TestSkillSlotsSettings ()
	{
		UUnitAssert.Equals ("SLT_A01",
		                    getXmlData.skillSlotsSettings.Items [0].Index);
	}

	[UUnitTest]
	public void TestSkillsSettings ()
	{
		UUnitAssert.Equals ("SKL_A01",
		                    getXmlData.skillsSettings.Items [0].Index);
	}

	[UUnitTest]
	public void TestSkillStonesSettings ()
	{
		UUnitAssert.Equals ("SKE_001",
		                    getXmlData.skillStonesSettings.Items [0].Index);
	}

	[UUnitTest]
	public void TestZonesSettings ()
	{
		UUnitAssert.Equals ("ZON_011",
		                    getXmlData.zonesSettings.Items [0].Index);
	}
	#endregion

	#region 특정 아이템 얻기
	[UUnitTest]
	public void TestAIsSettingsAI ()
	{
		UUnitAssert.Equals ("MSK_001",
		                    getXmlData.GetAIsSettingsAI (
			"MAI_001").SkillFirstCheck);
	}

	public void TestBossSkillsSettingsBossSkill ()
	{
		UUnitAssert.Equals (0.0,
		                    getXmlData.GetBossSkillsSettingsBossSkill (
			"MSK_001").SkillType);
	}

	[UUnitTest]
	public void TestCostumeBasesSettingsCostumeBase ()
	{
		UUnitAssert.Equals (0.0,
		                    getXmlData.GetCostumeBasesSettingsCostumeBase (
			"COB_001").Cash);
	}

	[UUnitTest]
	public void TestDropItemsSettingsDropItemZone0101 ()
	{
		UUnitAssert.Equals (0.0,
		                    getXmlData.GetDropItemsSettingsDropItemZone0101 (
			"DRP_FSH").NoItemRate);
	}

	[UUnitTest]
	public void TestEnemiesSettingsEnemy ()
	{
		UUnitAssert.Equals (1.0,
		                    getXmlData.GetEnemiesSettingsEnemy (
			"MOB_B01").Level);
	}

	[UUnitTest]
	public void TestItemCostumesSettingsItemCostume ()
	{
		UUnitAssert.Equals (0.0,
		                    getXmlData.GetItemCostumesSettingsItemCostume (
			"COS_001").HelmetType);
	}

	[UUnitTest]
	public void TestItemEtcsSettingsItemEtc ()
	{
		UUnitAssert.Equals ("휴대폰",
		                    getXmlData.GetItemEtcsSettingsItemEtc (
			"ETC_001").Name);
	}

	[UUnitTest]
	public void TestItemPuzzlePiecesSettingsItemPuzzlePiece ()
	{
		UUnitAssert.Equals ("1쪽의 첫번째 조각",
		                    getXmlData.GetItemPuzzlePiecesSettingsItemPuzzlePiece (
			"PUZ_001").Name);
	}

	[UUnitTest]
	public void TestItemSkillStonesSettingsItemSkillStone ()
	{
		UUnitAssert.Equals ("붉은 꿈의 파편",
		                    getXmlData.GetItemSkillStonesSettingsItemSkillStone (
			"SKS_A01").Name);
	}

	[UUnitTest]
	public void TestItemWarfStonesSettingsItemWarfStone ()
	{
		UUnitAssert.Equals ("마이어드 1번 퍼즐 조각",
		                    getXmlData.GetItemWarfStonesSettingsItemWarfStone (
			"WAF_011").Name);
	}

	[UUnitTest]
	public void TestItemWeaponsSettingsItemWeapon ()
	{
		UUnitAssert.Equals ("큐피티안의 무기",
		                    getXmlData.GetItemWeaponsSettingsItemWeapon (
			"WPN_001").Name);
	}

	[UUnitTest]
	public void TestItemWeaponStrengthenStonesSettingsItemWeaponStrengthenStone ()
	{
		UUnitAssert.Equals ("공격성",
		                    getXmlData.GetItemWeaponStrengthenStonesSettingsItemWeaponStrengthenStone (
			"WUS_001").Name);
	}

	[UUnitTest]
	public void TestPlayerLevelsSettingsPlayerLevel ()
	{
		UUnitAssert.Equals (100.0,
		                    getXmlData.GetPlayerLevelsSettingsPlayerLevel (
			"Level1").MaxHP);
	}

	[UUnitTest]
	public void TestPlayersSettingsPlayer ()
	{
		UUnitAssert.Equals (1.0,
		                    getXmlData.GetPlayersSettingsPlayer (
			"Player1").Sex);
	}

	[UUnitTest]
	public void TestPuzzleBasesSettingsPuzzleBase ()
	{
		UUnitAssert.Equals ("(1쪽) 꿈과 상상의 세계",
		                    getXmlData.GetPuzzleBasesSettingsPuzzleBase (
			"PUB_012").Name);
	}

	[UUnitTest]
	public void TestSkillSlotsSettingsSkillSlot ()
	{
		UUnitAssert.Equals ("회복구슬 슬롯",
		                    getXmlData.GetSkillSlotsSettingsSkillSlot (
			"SLT_A01").Name);
	}

	[UUnitTest]
	public void TestSkillsSettingsSkill ()
	{
		UUnitAssert.Equals ("지면강타",
		                    getXmlData.GetSkillsSettingsSkill (
			"SKL_A01").SkillName);
	}

	[UUnitTest]
	public void TestSkillStonesSettingsSkillStone ()
	{
		UUnitAssert.Equals ("1레벨 스킬석 효과",
		                    getXmlData.GetSkillStonesSettingsSkillStone (
			"SKE_001").Name);
	}

	[UUnitTest]
	public void TestZonesSettingsZone ()
	{
		UUnitAssert.Equals ("숲 1",
		                    getXmlData.GetZonesSettingsZone (
			"ZON_011").Name);
	}
	#endregion

	#region 유틸리티 메소드
	[UUnitTest]
	public void TestFindItemType ()
	{
		UUnitAssert.Equals (Enum.GetName(typeof(XmlDataType), XmlDataType.COS),
		                    Enum.GetName (typeof(XmlDataType),
		                                  getXmlData.FindItemType (
			"COS_impomen_weapon_01")));
	}

	[UUnitTest]
	public void TestGetFindItem ()
	{
		UUnitAssert.Equals ("스위퍼 A1",
		                    ((EnemiesSettingsEnemy)(getXmlData.GetFindItem (
			"MOB_B01"))).Description);
	}

	[UUnitTest]
	public void TestStringToProperty ()
	{
		var enemySetting = getXmlData.enemiesSettings.Items [0];
		var enemyProperty = enemySetting.GetType ().GetProperty ("Level");
		var enemyValue = enemyProperty.GetValue (enemySetting, null);
		UUnitAssert.Equals (1.0, (float)enemyValue);
	}

	[UUnitTest]
	public void TestIsCashItem ()
	{
		UUnitAssert.Equals (true, getXmlData.IsCashItem ("ETC_006"));
	}
	#endregion

}
