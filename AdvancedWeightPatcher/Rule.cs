using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedWeightPatcher
{
    public enum TargetType {
        Armor
    }

    public enum ArmorType
    {
        NotSpecified = -1,
        LightArmor = 0,
        HeavyArmor = 1,
        Clothing = 2
    }
    public enum BipedObjectFlag : uint
    {
        NotSpecified = 0u,
        Head = 1u,
        Hair = 2u,
        Body = 4u,
        Hands = 8u,
        Forearms = 0x10u,
        Amulet = 0x20u,
        Ring = 0x40u,
        Feet = 0x80u,
        Calves = 0x100u,
        Shield = 0x200u,
        Tail = 0x400u,
        LongHair = 0x800u,
        Circlet = 0x1000u,
        Ears = 0x2000u,
        DecapitateHead = 0x100000u,
        Decapitate = 0x200000u,
        FX01 = 0x80000000u
    }
    public class Rule
    {
        public TargetType Target { get; set; }
        public List<Condition>? Conditions { get; set; }
        public TargetValue? TargetValue { get; set; }
    }

    public class Condition
    {
        public List<IFormLinkGetter<IKeywordGetter>>? Keywords { get; set; }
        public ArmorType ArmorType { get; set; }
        public BipedObjectFlag FirstPersonFlags { get; set; }
    }

    public class TargetValue
    {
        public bool PatchWeight { get; set; } = true;
        public float Weight { get; set; }
        public bool PatchValue { get; set; } = true;
        public int Value { get; set; }
        public bool PatchArmorRating { get; set; } = true;
        public float ArmorRating { get; set; }
    }
}
