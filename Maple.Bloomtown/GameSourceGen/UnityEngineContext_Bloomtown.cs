using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Microsoft.Extensions.Logging;

namespace Maple.Bloomtown
{
    internal sealed partial class UnityEngineContext_Bloomtown : UnityEngineContext
    {
        public UnityEngineContext_Bloomtown(MonoRuntimeContext runtimeContext, ILogger logger) : base(runtimeContext, EnumMonoCollectorTypeVersion.Ver_MONO, logger)
        {
            //用MONO 编译的GAME 获取到UnityPlayer.dll 函数地址偏移不一样 需要根据每个游戏修改
            this.NativeMethodSetting.LoadNativeMethod_MONO(offset_encode_to_png: 0x217030, offset_blit2: 0x878C0);
        }
    }
}
