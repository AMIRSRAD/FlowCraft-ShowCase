namespace FlowCraft.Showcase;

/// <summary>
/// Public showcase metadata only. This file contains no production FlowCraft logic.
/// </summary>
public static class FlowCraftProductInfo
{
    public const string ProductName = "FlowCraft";
    public const string ProductType = "Windows visual flow configuration editor";
    public const string Creator = "Amirsalar Saberi rad";
    public const string Website = "https://amirsrad.ir";

    public static IReadOnlyList<string> PublicFeatureSummary { get; } =
    [
        "Node-based workflow editing",
        "Package navigation",
        "Connection routing and validation",
        "Expression authoring assistance",
        "Search, replace, and compare tools",
        "AI-assisted flow patch generation",
        "Flow-linked UI screen designer",
        "Live preview and React-style export"
    ];
}
