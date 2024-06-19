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
        Armor,
        Weapon
    }

    public class Rule
    {
        TargetType Target { get; set; }
        List<Condition>? Conditions { get; set; }
        List<TargetValue>? TargetValues { get; set; }
    }

    public class Condition
    {
        List<IFormLinkGetter<IKeywordGetter>>? Keywords { get; set; }
        ArmorType ArmorType { get; set; }
        BipedObjectFlag BodyTemplate { get; set; }
    }

    public class TargetValue
    {
        public float Weight { get; set; }
        public int Value { get; set; }
        public float ArmorRating { get; set; }
    }
}
