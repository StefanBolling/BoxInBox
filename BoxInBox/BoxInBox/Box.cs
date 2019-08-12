namespace BoxInBox
{
    public class Box : IBox
    {
        public Box ContainedBox { get; set; }
        private int _numberOfContainingBoxes = 0;

        public int GetNumberOfContaintingBoxes
        {
            get
            {
                SetNumberOfContaintingBoxes(this);

                return _numberOfContainingBoxes;
            }
        }

        private void SetNumberOfContaintingBoxes(Box box)
        {
            if (box.ContainedBox != null)
            {
                _numberOfContainingBoxes++;
                SetNumberOfContaintingBoxes(box.ContainedBox);
            }
        }
    }
}