﻿using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Interfaces;
using Exiled.Events.Commands.Reload;
using SCPSLAudioApi;
using YongAnFrame.Players;
using YongAnFrame.Roles;

namespace YongAnFrame
{
    /// <summary>
    /// 插件的驱动
    /// </summary>
    public sealed class YongAnFramePlugin : Plugin<Config, Translation>
    {
        private static YongAnFramePlugin instance;
        /// <summary>
        /// 获取单例
        /// </summary>
        public static YongAnFramePlugin Instance => instance;
        ///<inheritdoc/>
        public override PluginPriority Priority => PluginPriority.First;
        ///<inheritdoc/>
        public override bool IgnoreRequiredVersionCheck => true;

        ///<inheritdoc/>
        public override void OnEnabled()
        {
            instance = this;
            Log.Info("\r\n __  __     ______     __   __     ______     ______     __   __    \r\n/\\ \\_\\ \\   /\\  __ \\   /\\ \"-.\\ \\   /\\  ___\\   /\\  __ \\   /\\ \"-.\\ \\   \r\n\\ \\____ \\  \\ \\ \\/\\ \\  \\ \\ \\-.  \\  \\ \\ \\__ \\  \\ \\  __ \\  \\ \\ \\-.  \\  \r\n \\/\\_____\\  \\ \\_____\\  \\ \\_\\\\\"\\_\\  \\ \\_____\\  \\ \\_\\ \\_\\  \\ \\_\\\\\"\\_\\ \r\n  \\/_____/   \\/_____/   \\/_/ \\/_/   \\/_____/   \\/_/\\/_/   \\/_/ \\/_/ \r\n                                                                    \r\n ______   ______     ______     __    __     ______                 \r\n/\\  ___\\ /\\  == \\   /\\  __ \\   /\\ \"-./  \\   /\\  ___\\                \r\n\\ \\  __\\ \\ \\  __<   \\ \\  __ \\  \\ \\ \\-./\\ \\  \\ \\  __\\                \r\n \\ \\_\\    \\ \\_\\ \\_\\  \\ \\_\\ \\_\\  \\ \\_\\ \\ \\_\\  \\ \\_____\\              \r\n  \\/_/     \\/_/ /_/   \\/_/\\/_/   \\/_/  \\/_/   \\/_____/              \r\n                                                                    \r\n ");
            Log.Info("============System============");
            FramePlayer.SubscribeStaticEvents();
            MusicManager.Instance.Init();
            CustomRolePlus.SubscribeStaticEvents();
            Startup.SetupDependencies();
            base.OnEnabled();
        }

        ///<inheritdoc/>
        public override void OnDisabled()
        {
            instance = null;
            FramePlayer.UnsubscribeStaticEvents();
            CustomRolePlus.UnsubscribeStaticEvents();
            base.OnDisabled();
        }
    }
}
