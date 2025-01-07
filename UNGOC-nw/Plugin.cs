using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Events;

namespace UNGOC_NW
{
    public class Plugin
    {
        [PluginConfig]
        public static Config Config;
        private static EventHandlers Handlers { get; set; } = new EventHandlers();
        [PluginEntryPoint("UNGOC-NWAPI","1.0.4","SCP:SL UNGOC Plugin","史蒂夫")]
        internal void OnEnabled()
        {
            Log.Info("成功加载UNGOC插件 / Enable Plugin \"UNGOC\" By 史蒂夫");
            Log.Info("如果你在某些购物平台购买到这个插件，请立刻退款并投诉！");
            Log.Info("插件作者: 萌新社区服务器 & 史蒂夫 ，GitHub仓库:https://github.com/MengXinSheQu/UNGOC");
            EventManager.RegisterEvents(Handlers);
        } 
    }
}
