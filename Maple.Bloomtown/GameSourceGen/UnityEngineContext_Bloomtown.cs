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
                //UnityEngine.ImageConversion:EncodeToPNG+77 - 48 B8 2072CE2DFD7F0000 - mov rax,UnityPlayer.dll+217220 { ("@USWH?l$?H???") }
                Func_ENCODE_TO_PNG = 0x217220,

                //UnityEngine.Graphics:Blit2+7f - 48 B8 8084B52DFD7F0000 - mov rax,UnityPlayer.dll+88480 { ("@USVWAUAVH?l$?H??8") }
                Func_BLIT2 = 0x88480,

                //UnityEngine.Sprite:get_rect_Injected+86 - 48 B8 509DBE2DFD7F0000 - mov rax,UnityPlayer.dll+119D50 { (610044232) }
                Func_GET_RECT_INJECTED = 0x119D50,

                //UnityEngine.Sprite:GetTextureRect_Injected+86 - 48 B8 408FBE2DFD7F0000 - mov rax,UnityPlayer.dll+118F40 { (610044232) }
                Func_GET_TEXTURE_RECT_INJECTED = 0x118F40
            });
        }
    }
}
