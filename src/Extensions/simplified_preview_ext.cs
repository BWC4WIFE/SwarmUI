using SwarmUI.Core;
using SwarmUI.Utils;

namespace SimplifiedPreview.Extension;

public class SimplifiedPreviewExtension : Extension
{
    public override void OnInit()
    {
        Logs.Init("SimplifiedPreview extension loaded");
        
        // Register JavaScript file
        ScriptFiles.Add("Assets/simplified_preview.js");
        
        // Register CSS file
        StyleSheetFiles.Add("Assets/simplified_preview.css");
    }
}
