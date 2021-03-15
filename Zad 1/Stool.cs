namespace ContrVariant2
{
    public class Stool
    {
        private double _height;
        private Quality _quality;

        public double Height
        {
            get => _height;
            set => _height = value;
        }

        public Quality Quality
        {
            get => _quality;
            set => _quality = value;
        }

        public Stool(double height, Quality quality)
        {
            _height = height;
            _quality = quality;
        }

        public double AmountWood(double height)
        {
            if (Quality == Quality.Low)
            {
                return 4 * height + 12;
            }
            else
            {
                return 5 * height + 14;
            }
        }

        public virtual double Cost()
        {
            if (Quality == Quality.High)
            {
                return AmountWood(Height) * 4;
            }

            if (Quality == Quality.Average)
            {
                return AmountWood(Height) * 3;
            }
            else
            {
                return AmountWood(Height) * 2;
            }
        }

        public virtual string ToString()
        {   
            return $"Высота табуретки - {Height}, Качество табуретки {Quality}, Стоимость {Cost()}";
        }
    }
}