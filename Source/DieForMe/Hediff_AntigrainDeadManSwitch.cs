using Verse;

namespace DieForMe
{
    public class Hediff_AntigrainDeadManSwitch : HediffWithComps
    {
        public override void Notify_PawnDied()
        {
            base.Notify_PawnDied();
            var damageDef = DefDatabase<DamageDef>.GetNamedSilentFail("BombSuper");
            if (damageDef != null)
            {
                GenExplosion.DoExplosion(pawn.Corpse.Position, pawn.Corpse.Map, 14.9f, damageDef,
                    pawn.Corpse.InnerPawn, -1, 1f, null, null, null, null, null, 0f, 1, true, null, 0f, 1, 0.22f, true);
            }

            pawn.health.RemoveHediff(this);
        }
    }
}