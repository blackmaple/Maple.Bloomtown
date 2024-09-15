using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Microsoft.Extensions.Logging;

namespace Maple.Bloomtown
{
    internal sealed partial class UnityEngineContext_Bloomtown : UnityEngineContext
    {
        public UnityEngineContext_Bloomtown(MonoRuntimeContext runtimeContext, ILogger logger) : base(runtimeContext, EnumMonoCollectorTypeVersion.MONO, logger, "202409140230")
        {
            //用MONO 编译的GAME 获取到UnityPlayer.dll 函数地址偏移不一样 需要根据每个游戏修改
            this.NativeMethodSetting.LoadNativeMethod_MONO(new UnityNativeMethodOffset()
            {


            });
        }
    }
}
