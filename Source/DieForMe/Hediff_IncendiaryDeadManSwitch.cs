using RimWorld;
using Verse;

namespace DieForMe
{
    public class Hediff_IncendiaryDeadManSwitch : HediffWithComps
    {
        public override void Notify_PawnDied()
        {
            base.Notify_PawnDied();
            GenExplosion.DoExplosion(pawn.Corpse.Position, pawn.Corpse.Map, 3.5f, DamageDefOf.Flame,
                pawn.Corpse.InnerPawn);
            pawn.health.RemoveHediff(this);
        }
    }
}