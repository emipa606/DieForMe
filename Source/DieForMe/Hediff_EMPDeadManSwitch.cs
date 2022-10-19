using RimWorld;
using Verse;

namespace DieForMe;

public class Hediff_EMPDeadManSwitch : HediffWithComps
{
    public override void Notify_PawnDied()
    {
        base.Notify_PawnDied();
        GenExplosion.DoExplosion(pawn.Corpse.Position, pawn.Corpse.Map, 5.5f, DamageDefOf.EMP,
            pawn.Corpse.InnerPawn, -1, 1f, null, null, null, null, null, 0f, 1, null, true);
        pawn.health.RemoveHediff(this);
    }
}