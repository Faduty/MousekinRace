﻿using Verse;

namespace MousekinRace
{
    public class CompProperties_ApparelWithAttachedHeadgear : CompProperties
    {
        public ThingDef attachedHeadgearDef;

        [NoTranslate]
        public string toggleUiIconPath;

        public CompProperties_ApparelWithAttachedHeadgear()
        {
            compClass = typeof(CompApparelWithAttachedHeadgear);
        }
    }
}
