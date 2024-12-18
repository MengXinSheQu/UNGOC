using Exiled.API.Features;
using System;

namespace UNGOC
{
    public class Plugin : Plugin<Config>
    {
        /*
         倒卖不会让你有什么好处，只会让你失去爹妈
         */
        internal static Plugin UNGOCPlugin { get; } = new Plugin();
        public override string Author { get; } = "萌新社区服务器 & 史蒂夫";
        public override string Name { get; } = "UNGOC插件 / UNGOC Plugin";
        public override Version Version { get; } = new Version(1,0,3,3);
        public override void OnEnabled()
        {
            Log.Info("成功加载UNGOC插件 / Enable Plugin \"UNGOC\" By 史蒂夫");
            Log.Info("如果你在某些购物平台购买到这个插件，请立刻退款并投诉！");
            Log.Info("插件作者: 萌新社区服务器 & 史蒂夫 ，GitHub仓库:https://github.com/MengXinSheQu/UNGOC");
            EventHandlers.RegEvent();
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            EventHandlers.UnRegEvent();
            base.OnDisabled();
        }
    }
}
