﻿using System;

namespace BoxInBox;

public class BoxFactory
{
    private Box _boxForDelivery = new();
    private int _totalNumberOfBoxes;

    public Box CreateBoxWithContainingBoxes(int numberOfContainingBoxes)
    {
        ResetBoxFactory();
        if (numberOfContainingBoxes == 0) throw new ArgumentOutOfRangeException("Can't return 0 boxes.");
        if (numberOfContainingBoxes == 1) return new Box { ContainedBox = new Box() };

        _totalNumberOfBoxes = numberOfContainingBoxes - 1;
        AddBox(_boxForDelivery);

        return _boxForDelivery;
    }

    private void ResetBoxFactory()
    {
        _boxForDelivery = new Box();
        _totalNumberOfBoxes = 0;
    }

    private void AddBox(IBox box)
    {
        if (_boxForDelivery.GetNumberOfContainingBoxes >= _totalNumberOfBoxes) return;

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