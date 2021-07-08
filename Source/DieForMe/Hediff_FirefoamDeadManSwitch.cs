using RimWorld;
using Verse;

namespace DieForMe
{
    public class Hediff_FirefoamDeadManSwitch : HediffWithComps
    {
        public override void Notify_PawnDied()
        {
            base.Notify_PawnDied();
            GenExplosion.DoExplosion(pawn.Corpse.Position, pawn.Corpse.Map, 5.5f, DamageDefOf.Extinguish,
                pawn.Corpse.InnerPawn, -1, 1f, null, null, null, null, ThingDefOf.Filth_FireFoam, 1.0f, 100, true);
            pawn.health.RemoveHediff(this);
        }
    }
}