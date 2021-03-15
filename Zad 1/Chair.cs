namespace ContrVariant2
{
    public class Chair:Stool
    {
        private double _backHeight;

        public double BackHeight
        {
            get => _backHeight;
            set => _backHeight = value;
        }

        public Chair(double height, Quality quality, double backHeight) : base(height, quality)
        {
            _backHeight = backHeight;
        }

        public double AmountWood1(double height)
        {
            return AmountWood(height) + 2 * height * 2 + 5;
        }

        public override string ToString()
        {
            return $"Высота стула - {Height}, Высота спинки - {BackHeight}, Качество табуретки {Quality}, Стоимость {Cost()}";
        }
    }
}