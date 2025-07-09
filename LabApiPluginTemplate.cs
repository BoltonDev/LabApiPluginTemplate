namespace LabApiPluginTemplate;

using System;
using LabApi.Features;
using LabApi.Loader.Features.Plugins;

public class LabApiPluginTemplate : Plugin<Config>
{
    public static LabApiPluginTemplate Instance { get; private set; } = null!;
    
    public override string Name { get; } = "LabApiPluginTemplate";
    public override string Description { get; } = "ProjectDescription";
    public override string Author { get; } = "ProjectAuthor";
    public override Version Version { get; } = new("ProjectVersion");
    public override Version RequiredApiVersion { get; } = new(LabApiProperties.CompiledVersion);

    public override void Enable()
    {
        Instance = this;
    }

    public override void Disable()
    {
        Instance = null!;
    }
}