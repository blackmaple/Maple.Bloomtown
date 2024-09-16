using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Microsoft.Extensions.Logging;
using System.Runtime.Intrinsics.X86;

namespace Maple.Bloomtown
{
    internal sealed partial class UnityEngineContext_Bloomtown : UnityEngineContext
    {
        public UnityEngineContext_Bloomtown(MonoRuntimeContext runtimeContext, ILogger logger) : base(runtimeContext, EnumMonoCollectorTypeVersion.MONO, logger, "202409140230")
        {
            //用MONO 编译的GAME 获取到UnityPlayer.dll 函数地址偏移不一样 需要根据每个游戏修改
            this.NativeMethodSetting.LoadNativeMethod_MONO(new UnityNativeMethodOffset()
            {
                //UnityEngine.ImageConversion:EncodeToPNG+77 - 48 B8 30708A17F97F0000 - mov rax,UnityPlayer.dll+217030 { ("@USWH?l$?H???") }

                Func_ENCODE_TO_PNG = 0x217030,
                //UnityEngine.Graphics:Blit2+7f - 48 B8 C07896A5F87F0000 - mov rax,UnityPlayer.dll+878C0 { ("@USWATAUH?l$?H??0") }
                Func_BLIT2 = 0x878C0,
                //UnityEngine.Sprite:get_rect_Injected+86 - 48 B8 00899FA5F87F0000 - mov rax,UnityPlayer.dll+118900 { (610044232) }
                Func_GET_RECT_INJECTED = 0x118900,
                //UnityEngine.Sprite:GetTextureRect_Injected+86 - 48 B8 F07A9FA5F87F0000 - mov rax,UnityPlayer.dll+117AF0 { (610044232) }
                Func_GET_TEXTURE_RECT_INJECTED = 0x117AF0
            });
        }
    }
}
