﻿using RimWorld;
using Verse;

namespace DieForMe
{
    public class Hediff_HighExplosiveDeadManSwitch : HediffWithComps
    {
        public override void Notify_PawnDied()
        {
            base.Notify_PawnDied();
            GenExplosion.DoExplosion(pawn.Corpse.Position, pawn.Corpse.Map, 3.5f, DamageDefOf.Bomb,
                pawn.Corpse.InnerPawn, -1, -1f, null, null, null, null, null, 0f, 1, true);
            pawn.health.RemoveHediff(this);
        }
    }
}