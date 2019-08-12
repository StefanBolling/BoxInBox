using System;

namespace BoxInBox
{
    public class BoxFactory
    {
        private Box _boxForDelivery = new Box();
        private int _totalNumberOfBoxes = 0;

        public Box CreateBoxWithContainingBoxes(int totalNumberOfBoxes)
        {
            ResetBoxFactory();
            if (totalNumberOfBoxes == 0) throw new ArgumentOutOfRangeException("Can't return 0 boxes.");

            if (totalNumberOfBoxes == 1) return new Box() { ContainedBox = new Box() };

            _totalNumberOfBoxes = totalNumberOfBoxes - 1;
            AddBox(_boxForDelivery);

            return _boxForDelivery;
        }

        private void ResetBoxFactory()
        {
            _boxForDelivery = new Box();
            _totalNumberOfBoxes = 0;
        }

        private void AddBox(Box box)
        {
            if (_boxForDelivery.GetNumberOfContaintingBoxes >= _totalNumberOfBoxes) return;

            if (box.ContainedBox != null)
            {
                AddBox(box.ContainedBox);
            }
            else
            {
                _boxForDelivery.ContainedBox = new Box();
                AddBox(_boxForDelivery.ContainedBox);
            }
        }
    }
}