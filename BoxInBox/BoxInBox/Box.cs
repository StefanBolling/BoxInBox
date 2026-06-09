namespace BoxInBox;

public class Box : IBox
{
    public Box ContainedBox { get; set; }

    public int GetNumberOfContainingBoxes =>
        ContainedBox is null ? 0 : 1 + ContainedBox.GetNumberOfContainingBoxes;
}
