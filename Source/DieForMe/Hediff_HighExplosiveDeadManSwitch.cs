using RimWorld;
using Verse;

namespace DieForMe;

public class Hediff_HighExplosiveDeadManSwitch : HediffWithComps
{
    public override void Notify_PawnDied(DamageInfo? dinfo, Hediff culprit = null)
    {
        base.Notify_PawnDied(dinfo, culprit);
        GenExplosion.DoExplosion(pawn.Corpse.Position, pawn.Corpse.Map, 3.5f, DamageDefOf.Bomb,
            pawn.Corpse.InnerPawn, -1, -1f, null, null, null, null, null, 0f, 1, null, null, 0, true);
        pawn.health.RemoveHediff(this);
    }
}