namespace FlowCraft.Showcase;

/// <summary>
/// Public showcase metadata only. This file contains no production FlowCraft logic.
/// </summary>
public static class FlowCraftProductInfo
{
    public const string ProductName = "FlowCraft";
    public const string ProductType = "Visual flow configuration editor";

    public static IReadOnlyList<string> PublicFeatureSummary { get; } =
    [
        "Node-based workflow editing",
        "Package navigation",
        "Connection validation",
        "Expression authoring assistance",
        "Search and compare tools"
    ];
}
