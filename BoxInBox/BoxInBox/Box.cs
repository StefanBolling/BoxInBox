namespace BoxInBox
{
    public class Box : IBox
    {
        public Box ContainedBox { get; set; }
        private int NumberOfContainingBoxes = 0;

        public int GetNumberOfContaintingBoxes
        {
            get
            {
                SetNumberOfContaintingBoxes(this);

                return NumberOfContainingBoxes;
            }
        }

        private void SetNumberOfContaintingBoxes(Box box)
        {
            if (box.ContainedBox != null)
            {
                NumberOfContainingBoxes++;
                SetNumberOfContaintingBoxes(box.ContainedBox);
            }
        }
    }
}