using RimWorld;
using Verse;

namespace LightConverterDemo
{
    public class CompLightConverter : CompPowerTrader
    {
        public new CompProperties_LightConverter Props => (CompProperties_LightConverter)base.props;

        public override void CompTick()
        {
            base.CompTick();

            if (!this.PowerOn)
                return;

            if (!this.parent.IsHashIntervalTick(60))
                return;

            float amount = Props.lightPerSecond / 60f;
            _ = amount;
        }
    }

    public class CompProperties_LightConverter : CompProperties
    {
        public float lightPerSecond = 60f;

        public CompProperties_LightConverter()
        {
            this.compClass = typeof(CompLightConverter);
        }
    }
}
