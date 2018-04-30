using System;
using System.Collections.Generic;
using System.Text;

public class Lion : Felidae
{
    private int weight;
    // Shall be explained in the next paragraph
    public Lion(bool male, int weight) : base(male)
    {
        this.weight = weight;
    }
    public int Weight
    {
        get
        {
            return weight;
        }
        set
        {
            this.weight = value;
        }
    }
}
