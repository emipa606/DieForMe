﻿using Verse;

namespace DieForMe;

public class Hediff_AntigrainDeadManSwitch : HediffWithComps
{
    public override void Notify_PawnDied(DamageInfo? dinfo, Hediff culprit = null)
    {
        base.Notify_PawnDied(dinfo, culprit);
        var damageDef = DefDatabase<DamageDef>.GetNamedSilentFail("BombSuper");
        if (damageDef != null)
        {
            GenExplosion.DoExplosion(pawn.Corpse.Position, pawn.Corpse.Map, 14.9f, damageDef,
                pawn.Corpse.InnerPawn, -1, 1f, null, null, null, null, null, 0f, 1, null, true, null, 0f, 1, 0.22f,
                true);
        }

        pawn.health.RemoveHediff(this);
    }
}