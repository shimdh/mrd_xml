using System.Xml.Serialization;


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public class SkillStonesSettings {
    
    private SkillStonesSettingsSkillStone[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SkillStone")]
    public SkillStonesSettingsSkillStone[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public class SkillStonesSettingsSkillStone : XmlData {
    
    private string indexField;
    
    private string nameField;
    
    private float skillStoneLevelField;
    
    private float wideRangeSkillRecoveryBeadRatioField;
    
    private float wideRangeSkillDownTimeField;
    
    private float wideRangeSkillCoolDownTimeField;
    
    private float wideRangeSkillDamageIncreasingRatioField;
    
    private float rushSkillMovementSpeedDecreasingTimeField;
    
    private float rushSkillBloodSuckingRatioField;
    
    private float rushSkillCoolDownTimeField;
    
    private float rushSkillDamageIncreasingRatioField;
    
    private float whirlWindSkillChargingSpeedDecreasingTimeField;
    
    private float whirlWindSkillChargingMovementSpeedIncreasingRatioField;
    
    private float whirlWindSkillRevCountField;
    
    private float whirlWindSkillDamageIncreasingRatioField;
    
    private float criticalAttackRatioField;
    
    private float blockRatioField;
    
    private float criticalAttackDamageRatioField;
    
    private float criticalAttackRecoveryHPField;
    
    private float increasingHPRatioField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Index")]
    public string Index {
        get {
            return this.indexField;
        }
        set {
            this.indexField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Name")]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SkillStoneLevel")]
    public float SkillStoneLevel {
        get {
            return this.skillStoneLevelField;
        }
        set {
            this.skillStoneLevelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("WideRangeSkillRecoveryBeadRatio")]
    public float WideRangeSkillRecoveryBeadRatio {
        get {
            return this.wideRangeSkillRecoveryBeadRatioField;
        }
        set {
            this.wideRangeSkillRecoveryBeadRatioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("WideRangeSkillDownTime")]
    public float WideRangeSkillDownTime {
        get {
            return this.wideRangeSkillDownTimeField;
        }
        set {
            this.wideRangeSkillDownTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("WideRangeSkillCoolDownTime")]
    public float WideRangeSkillCoolDownTime {
        get {
            return this.wideRangeSkillCoolDownTimeField;
        }
        set {
            this.wideRangeSkillCoolDownTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("WideRangeSkillDamageIncreasingRatio")]
    public float WideRangeSkillDamageIncreasingRatio {
        get {
            return this.wideRangeSkillDamageIncreasingRatioField;
        }
        set {
            this.wideRangeSkillDamageIncreasingRatioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RushSkillMovementSpeedDecreasingTime")]
    public float RushSkillMovementSpeedDecreasingTime {
        get {
            return this.rushSkillMovementSpeedDecreasingTimeField;
        }
        set {
            this.rushSkillMovementSpeedDecreasingTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RushSkillBloodSuckingRatio")]
    public float RushSkillBloodSuckingRatio {
        get {
            return this.rushSkillBloodSuckingRatioField;
        }
        set {
            this.rushSkillBloodSuckingRatioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RushSkillCoolDownTime")]
    public float RushSkillCoolDownTime {
        get {
            return this.rushSkillCoolDownTimeField;
        }
        set {
            this.rushSkillCoolDownTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RushSkillDamageIncreasingRatio")]
    public float RushSkillDamageIncreasingRatio {
        get {
            return this.rushSkillDamageIncreasingRatioField;
        }
        set {
            this.rushSkillDamageIncreasingRatioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("WhirlWindSkillChargingSpeedDecreasingTime")]
    public float WhirlWindSkillChargingSpeedDecreasingTime {
        get {
            return this.whirlWindSkillChargingSpeedDecreasingTimeField;
        }
        set {
            this.whirlWindSkillChargingSpeedDecreasingTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("WhirlWindSkillChargingMovementSpeedIncreasingRatio")]
    public float WhirlWindSkillChargingMovementSpeedIncreasingRatio {
        get {
            return this.whirlWindSkillChargingMovementSpeedIncreasingRatioField;
        }
        set {
            this.whirlWindSkillChargingMovementSpeedIncreasingRatioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("WhirlWindSkillRevCount")]
    public float WhirlWindSkillRevCount {
        get {
            return this.whirlWindSkillRevCountField;
        }
        set {
            this.whirlWindSkillRevCountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("WhirlWindSkillDamageIncreasingRatio")]
    public float WhirlWindSkillDamageIncreasingRatio {
        get {
            return this.whirlWindSkillDamageIncreasingRatioField;
        }
        set {
            this.whirlWindSkillDamageIncreasingRatioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CriticalAttackRatio")]
    public float CriticalAttackRatio {
        get {
            return this.criticalAttackRatioField;
        }
        set {
            this.criticalAttackRatioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BlockRatio")]
    public float BlockRatio {
        get {
            return this.blockRatioField;
        }
        set {
            this.blockRatioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CriticalAttackDamageRatio")]
    public float CriticalAttackDamageRatio {
        get {
            return this.criticalAttackDamageRatioField;
        }
        set {
            this.criticalAttackDamageRatioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CriticalAttackRecoveryHP")]
    public float CriticalAttackRecoveryHP {
        get {
            return this.criticalAttackRecoveryHPField;
        }
        set {
            this.criticalAttackRecoveryHPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("IncreasingHPRatio")]
    public float IncreasingHPRatio {
        get {
            return this.increasingHPRatioField;
        }
        set {
            this.increasingHPRatioField = value;
        }
    }
}
