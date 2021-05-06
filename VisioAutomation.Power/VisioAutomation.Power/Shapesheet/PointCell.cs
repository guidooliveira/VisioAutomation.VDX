namespace VisioAutomation.Power.ShapeSheet
{
    public class PointCell : CellScalar<double>
    {
        public PointCell()
            : base(CellUnit.Point)
        {
        }

        public override string GetResultString()
        {
            if (!this.Result.HasValue)
            {
                throw new System.ArgumentException("EnumCell does not have a value");
            }

            var invariant_culture = System.Globalization.CultureInfo.InvariantCulture;
            var inches = Converter.PointsToInches(this.Result.Value);
            return string.Format(invariant_culture, "{0}", inches);
        }
    }
}