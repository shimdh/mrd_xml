using System.Xml.Serialization;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public class PlayersSettings {
    
    private PlayersSettingsPlayer[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Player")]
    public PlayersSettingsPlayer[] Items {
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
public class PlayersSettingsPlayer {
    
    private string nameField;
    
    private float sexField;
    
    private float defaultAttackDistanceField;
    
    private float defaultAttackAngleField;
    
    private float defaultAttackSpeed1Field;
    
    private float defaultAttackSpeed2Field;
    
    private float defaultAttackSpeed3Field;
    
    private float defaultAttackDelayField;
    
    private float movingSpeedField;
    
    private float additionalHPField;
    
    private float blockPofloatField;
    
    private float criticalAttackRateField;
    
    private float criticalAttackDamageField;
    
    private float criticalAttackRecoveryPofloatField;
    
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
    [System.Xml.Serialization.XmlElementAttribute("Sex")]
    public float Sex {
        get {
            return this.sexField;
        }
        set {
            this.sexField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DefaultAttackDistance")]
    public float DefaultAttackDistance {
        get {
            return this.defaultAttackDistanceField;
        }
        set {
            this.defaultAttackDistanceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DefaultAttackAngle")]
    public float DefaultAttackAngle {
        get {
            return this.defaultAttackAngleField;
        }
        set {
            this.defaultAttackAngleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DefaultAttackSpeed1")]
    public float DefaultAttackSpeed1 {
        get {
            return this.defaultAttackSpeed1Field;
        }
        set {
            this.defaultAttackSpeed1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DefaultAttackSpeed2")]
    public float DefaultAttackSpeed2 {
        get {
            return this.defaultAttackSpeed2Field;
        }
        set {
            this.defaultAttackSpeed2Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DefaultAttackSpeed3")]
    public float DefaultAttackSpeed3 {
        get {
            return this.defaultAttackSpeed3Field;
        }
        set {
            this.defaultAttackSpeed3Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DefaultAttackDelay")]
    public float DefaultAttackDelay {
        get {
            return this.defaultAttackDelayField;
        }
        set {
            this.defaultAttackDelayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MovingSpeed")]
    public float MovingSpeed {
        get {
            return this.movingSpeedField;
        }
        set {
            this.movingSpeedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AdditionalHP")]
    public float AdditionalHP {
        get {
            return this.additionalHPField;
        }
        set {
            this.additionalHPField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BlockPofloat")]
    public float BlockPofloat {
        get {
            return this.blockPofloatField;
        }
        set {
            this.blockPofloatField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CriticalAttackRate")]
    public float CriticalAttackRate {
        get {
            return this.criticalAttackRateField;
        }
        set {
            this.criticalAttackRateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CriticalAttackDamage")]
    public float CriticalAttackDamage {
        get {
            return this.criticalAttackDamageField;
        }
        set {
            this.criticalAttackDamageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CriticalAttackRecoveryPofloat")]
    public float CriticalAttackRecoveryPofloat {
        get {
            return this.criticalAttackRecoveryPofloatField;
        }
        set {
            this.criticalAttackRecoveryPofloatField = value;
        }
    }
}
