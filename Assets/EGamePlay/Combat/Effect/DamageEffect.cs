﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System.IO;
using Sirenix.Utilities.Editor;
using System.Linq;
using UnityEditor;
using System.Reflection;

namespace EGamePlay.Combat
{
    [Effect("造成伤害")]
    public class DamageEffect : Effect
    {
        public override string Label => "造成伤害";

        [ToggleGroup("Enabled")]
        public DamageType DamageType;

        [ToggleGroup("Enabled"), LabelText("伤害取值")]
        public string DamageValue;

        [ToggleGroup("Enabled"), LabelText("是否可以暴击")]
        public bool CanCrit;
    }
}