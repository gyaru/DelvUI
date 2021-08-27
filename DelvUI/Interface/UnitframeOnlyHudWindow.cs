﻿using Dalamud.Plugin;

namespace DelvUI.Interface {
    public class UnitFrameOnlyHudWindow : HudWindow {
        public override uint JobId => 23;

        public UnitFrameOnlyHudWindow(DalamudPluginInterface pluginInterface, PluginConfiguration pluginConfiguration) : base(pluginInterface, pluginConfiguration) { }

        protected override void Draw(bool _) {
            DrawHealthBar();
            DrawPrimaryResourceBar();
            DrawTargetBar();
            DrawFocusBar();
            DrawCastBar();
        }
        
    }
}