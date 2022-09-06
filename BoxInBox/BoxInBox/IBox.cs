namespace BoxInBox;

public interface IBox
{
    Box ContainedBox { get; set; }

    int GetNumberOfContainingBoxes { get; }
}