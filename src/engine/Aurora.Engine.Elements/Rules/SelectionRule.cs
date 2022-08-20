﻿namespace Aurora.Engine.Elements.Rules;

/// <summary>
/// Initializes a new instance of the <see cref="SelectionRule"/> class.
/// </summary>
public class SelectionRule : ElementRuleBase
{
    public SelectionRule(string elementType)
    {
        ElementType = elementType;
        UniqueIdentifier = Guid.NewGuid();
    }

    /// <summary>
    /// Gets a unique internal identifier for the selection rule.
    /// </summary>
    public Guid UniqueIdentifier { get; set; }

    /// <summary>
    /// Gets or sets the element type for the selection rule.
    /// </summary>
    public string ElementType { get; set; }

    /// <summary>
    /// Gets or sets the level prerequisite for the selection rule.
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// Gets or sets the quantity of selections that can be made with this rule.
    /// <para>Default is 1</para>
    /// </summary>
    public int Quantity { get; set; } = 1;

    public override string ToString()
    {
        return $"{base.ToString()} ({ElementType})";
    }
}
