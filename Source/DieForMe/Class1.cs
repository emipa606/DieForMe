using RimWorld;
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


    public class Hediff_EMPDeadManSwitch : HediffWithComps
    {
        public override void Notify_PawnDied()
        {
            base.Notify_PawnDied();
            GenExplosion.DoExplosion(pawn.Corpse.Position, pawn.Corpse.Map, 5.5f, DamageDefOf.EMP,
                pawn.Corpse.InnerPawn, -1, 1f, null, null, null, null, null, 0f, 1, true);
            pawn.health.RemoveHediff(this);
        }
    }


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