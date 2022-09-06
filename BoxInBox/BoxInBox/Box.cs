namespace BoxInBox;

public class Box : IBox
{
    public Box ContainedBox { get; set; }

    private int _numberOfContainingBoxes = 0;

    public int GetNumberOfContainingBoxes
    {
        get
        {
            SetNumberOfContainingBoxes(this);

            return _numberOfContainingBoxes;
        }
    }

    private void SetNumberOfContainingBoxes(IBox box)
    {
        if (box.ContainedBox is null) return;

        _numberOfContainingBoxes++;
        SetNumberOfContainingBoxes(box.ContainedBox);
    }
}