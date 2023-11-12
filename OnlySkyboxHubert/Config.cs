using System.ComponentModel;

namespace OnlySkyboxHubert
{
    public class Config
    {
        [Description("Plugin Enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Enable developer mode? (AudioPlayer debug)")]
        public bool Debug { get; set; } = false;
    }
}
